using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System.Data;
using System.Net;
using System.IO;


namespace aluno.bepiducb.com.br.Alunos
{
    public partial class Foto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtNumero.Focus();
                preencherGridAluno();
            }
        }


        private void preencherGridAluno()
        {
            if (Session["SAluno"] != null)
            {
                if (Session["SAluno"].Equals("A"))
                {
                    AlunoDTO dto = new AlunoDTO();
                    dto.idAluno = int.Parse(Session["IAluno"].ToString());

                    AlunoBRL brl = new AlunoBRL();
                    DataTable dt = brl.searchDadosPrincipais(dto);
                    grdDadosAluno.DataSource = dt;
                    grdDadosAluno.DataBind();

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        //if (!String.IsNullOrEmpty(dt.Rows[0]["Numero"].ToString()))
                        txtNumero.Text = dt.Rows[0]["Numero"].ToString();
                        String imagem = dt.Rows[0]["Foto"].ToString();
                        if (!String.IsNullOrEmpty(imagem))
                        {
                            lblImagem.Text = "<img src='http://s3.amazonaws.com/BEPiD/" + imagem + "' style='border-radius:20px; width:200px;'/>";
                            cmdEnviarImagem.Visible = false;
                        }
                    }
                }
            }
        }
        protected void cmdEnviarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNumero.Text))
                {
                    lblImagem.Text = "Digite o número do seu Kit";
                    txtNumero.Focus();
                    return;
                }
                else
                {

                    int tamanho = flUploadImagem.PostedFile.ContentLength;

                    if (tamanho <= 4000000)
                    {
                        string filename = System.IO.Path.GetFileName(flUploadImagem.PostedFile.FileName);
                        filename = Guid.NewGuid() + filename;


                        TransferUtility fileTransferUtility = new
                            TransferUtility(System.Configuration.ConfigurationManager.AppSettings["AccessKey"].ToString(),
                                            System.Configuration.ConfigurationManager.AppSettings["SecretKey"].ToString());

                        var uploadRequest = new Amazon.S3.Transfer.TransferUtilityUploadRequest();
                        uploadRequest.InputStream = flUploadImagem.PostedFile.InputStream;
                        uploadRequest.BucketName = "BEPiD";
                        uploadRequest.Key = filename;
                        uploadRequest.StorageClass = S3StorageClass.ReducedRedundancy;
                        uploadRequest.CannedACL = S3CannedACL.PublicRead;


                        fileTransferUtility.Upload(uploadRequest);

                        lblImagem.Text = "<img src='http://s3.amazonaws.com/BEPiD/" + filename.ToString() + "' style='border-radius:30px;'/>";

                        string urlImagem = "http://s3.amazonaws.com/BEPiD/" + filename.ToString();
                        HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(urlImagem);
                        HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        Stream stream = httpWebReponse.GetResponseStream();

                        System.Drawing.Image objImage = System.Drawing.Image.FromStream(stream);
                        int w = objImage.Width;
                        int h = objImage.Height;

                        if (w <= 500 && h <= 500)
                        {
                            //atualizar o banco de dados.
                            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

                            AlunoDTO dto = new AlunoDTO();
                            dto.idAluno = int.Parse(Session["IAluno"].ToString());

                            if (txtNumero.Text.Length > 0)
                                dto.numero = int.Parse(txtNumero.Text);

                            dto.foto = filename.ToString();

                            AlunoBRL alunoBRL = new AlunoBRL();
                            if (alunoBRL.updateAlunoNumeroMaquinaImagem(dto))
                            {
                                //lblImagem.Text = "Foto enviada com sucesso.";
                                //cmdEnviarImagem.Visible = false; //esconde o botao.
                            }
                            else { }
                            //sResponse.Write("Não feito");
                        }
                        else
                            lblImagem.Text = "A imagem deve a largura e altura de no máximo 500 pixels.";
                    }
                    else
                    {
                        lblImagem.Text = "A imagem deve ser menor do que 4.000.000 bytes.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblImagem.Text = ex.Message.ToString() + " - " + ex.StackTrace.ToString();
            }
        }
    }
}