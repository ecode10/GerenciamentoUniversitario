using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Amazon.S3.Model;
using Amazon.S3.Transfer;
using BEPiD.Business.BRL;
using BEPiD.Business.DTO;

namespace aluno.bepiducb.com.br.Alunos
{
    public partial class AddAplicativo : System.Web.UI.Page
    {
        protected void Page_PreInit(Object sender, EventArgs e)
        {
            //verificaProfessorOuAluno(1);

        }

        //private void verificaProfessorOuAluno(int inicial)
        //{
        //    if (Session["N"] == null)
        //    {
        //        Response.Redirect("/Private/Login");
        //    }

        //    //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
        //    //if (Session != null && !Session["S"].Equals("P"))
        //    if (Session["S"].Equals("A"))
        //    {
        //        this.MasterPageFile = "~/Logado.Master";
        //    }
        //    else if(Session["S"].Equals("P")) //P é para os professores
        //    {
        //        //pnlAdministrativo.Visible = true;
        //        this.MasterPageFile = "~/Adm.Master";
        //        //if (inicial == 0)
        //        //{
        //            //grdDadosAluno.Visible = false;
        //            //pnlFoto.Visible = false;
        //            //pnlInformacao.Visible = false;
        //            //lblTitulo.Text = "Área restrita a Professores.";
        //        //}
        //        //else
        //            //this.MasterPageFile = "~/Adm.Master";

        //    }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Equals("sucesso"))
                    lblResultado.Text = "Cadastro realizado com sucesso.";
                else if (Request.Params["id"] != null && Request.Params["id"].Equals("deletado"))
                    lblResultado.Text = "Deletado com sucesso";
                else
                    lblResultado.Text = "";

                preencherGridCategoria();
                preencherGridView();
            }
        }

        private void preencherGridView()
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            AplicativoDTO dto = new AplicativoDTO();

            if (Session["SAluno"] != null)
            {
                //verifica se é professor, se for pega todos os apps.
                if (Session["SAluno"].Equals("A")) //diferente de P
                    dto.idAluno = int.Parse(Session["IAluno"].ToString());

                AplicativoBRL brl = new AplicativoBRL();
                this.gridAplicativos.DataSource = brl.searchAplicativo(dto);
                this.gridAplicativos.DataBind();
            }
            else
            {
                Response.Redirect("../Login");
            }
        }

        private void preencherGridCategoria()
        {
            CategoriaDTO dto = new CategoriaDTO();
            

            CategoriaBRL _categoriaBRL = new CategoriaBRL();
            this.cmbCategoria.DataSource = _categoriaBRL.searchCategoria(dto);

            this.cmbCategoria.DataTextField = "NomeCategoria";
            this.cmbCategoria.DataValueField = "IdCategoria";
            this.cmbCategoria.DataBind();

            this.cmbCategoria.Items.Insert(0, new ListItem("Selecione", ""));
            //this.cmbCategoria.Attributes.Add("0", "Selecione");
        }

        protected void cmdCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    //atualizar o banco de dados.
                    //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

                    AplicativoDTO _aplicativoDTO = new AplicativoDTO();
                    _aplicativoDTO.idCategoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                    _aplicativoDTO.linkAplicativo = txtLink.Text;
                    _aplicativoDTO.nomeAplicativo = txtNome.Text;
                    _aplicativoDTO.situacao = "P";
                    _aplicativoDTO.nomeGrupoAplicativo = txtGrupo.Text;
                    _aplicativoDTO.idAluno = int.Parse(Session["IAluno"].ToString());
                    _aplicativoDTO.ano = txtAno.Text;
                    _aplicativoDTO.challenge = cmbChallenge.SelectedValue.ToString();
                    _aplicativoDTO.descricaoAplicativo = txtDescricao.Text;
                    _aplicativoDTO.dataPublicacaoAplicativo = Convert.ToDateTime(txtDataPublicacao.Text);

                    //imagem
                    int tamanho = flImagem.PostedFile.ContentLength;

                    if (tamanho == 0)
                    {
                        lblResultado.Text = "Por favor envie a logomarca do aplicativo";
                        return;
                    }

                    if (tamanho <= 4000000)
                    {
                        //icone
                        string filename = System.IO.Path.GetFileName(flImagem.PostedFile.FileName);
                        filename = Guid.NewGuid() + filename;
                        string icone = uploadImagem(filename, flImagem.PostedFile.InputStream);

                        HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(icone);
                        HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        Stream stream = httpWebReponse.GetResponseStream();

                        System.Drawing.Image objImage = System.Drawing.Image.FromStream(stream);
                        int w = objImage.Width;
                        int h = objImage.Height;

                        if (w <= 120 && h <= 120)
                        {
                            //imagem1
                            string filename1 = System.IO.Path.GetFileName(flImagem1.PostedFile.FileName);
                            filename1 = Guid.NewGuid() + filename1;
                            string imagem1 = uploadImagem(filename1, flImagem1.PostedFile.InputStream);

                            httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(imagem1);
                            httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                            stream = httpWebReponse.GetResponseStream();

                            objImage = System.Drawing.Image.FromStream(stream);
                            w = objImage.Width;
                            h = objImage.Height;



                            //imagem2
                            string filename2 = System.IO.Path.GetFileName(flImagem2.PostedFile.FileName);
                            filename2 = Guid.NewGuid() + filename2;
                            string imagem2 = uploadImagem(filename2, flImagem2.PostedFile.InputStream);

                            httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(imagem2);
                            httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                            stream = httpWebReponse.GetResponseStream();

                            objImage = System.Drawing.Image.FromStream(stream);
                            w = objImage.Width;
                            h = objImage.Height;

                            if ((w == 392 && h == 696) || (w == 512 && h == 384))
                            {
                                //imagem3
                                string filename3 = System.IO.Path.GetFileName(flImagem3.PostedFile.FileName);
                                filename3 = Guid.NewGuid() + filename3;
                                string imagem3 = uploadImagem(filename3, flImagem3.PostedFile.InputStream);


                                _aplicativoDTO.imagemAplicativo = filename.ToString();
                                _aplicativoDTO.imagemAplicativo1 = filename1.ToString();
                                _aplicativoDTO.imagemAplicativo2 = filename2.ToString();
                                _aplicativoDTO.imagemAplicativo3 = filename3.ToString();

                                //insere no banco de dados
                                AplicativoBRL _aplicativoBRL = new AplicativoBRL();
                                if (_aplicativoBRL.insertAplicativo(_aplicativoDTO))
                                {
                                    Response.Redirect("AddAplicativo?id=sucesso");
                                }//teste

                            }
                            else
                            {
                                lblResultado.Text = "A imagem deve respeitar o tamanho informado. Dimensões: 392 x 696.";
                                return;
                            }
                        }
                        else
                        {
                            lblResultado.Text = "A imagem deve respeitar o tamanho informado. Dimensões: 120 x 120.";
                            return;
                        }
                    }
                    else
                    {
                        lblResultado.Text = "A imagem deve respeitar o tamanho informado. Dimensões: 120 x 120.";
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }

        private string uploadImagem(string filename, Stream fileStream)
        {
            TransferUtility fileTransferUtility = new
                                         TransferUtility(System.Configuration.ConfigurationManager.AppSettings["AccessKey"].ToString(),
                                                         System.Configuration.ConfigurationManager.AppSettings["SecretKey"].ToString());

            var uploadRequest = new Amazon.S3.Transfer.TransferUtilityUploadRequest();
            uploadRequest.InputStream = fileStream;//flImagem.PostedFile.InputStream;
            uploadRequest.BucketName = "BEPiD";
            uploadRequest.Key = filename;
            uploadRequest.StorageClass = S3StorageClass.ReducedRedundancy;
            uploadRequest.CannedACL = S3CannedACL.PublicRead;


            fileTransferUtility.Upload(uploadRequest);

            //lblImagem.Text = "<img src='http://s3.amazonaws.com/BEPiD/" + filename.ToString() + "' style='border-radius:30px;'/>";

            string urlImagem = "http://s3.amazonaws.com/BEPiD/" + filename.ToString();
            return urlImagem;
            //HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(urlImagem);
            //HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //Stream stream = httpWebReponse.GetResponseStream();

            //System.Drawing.Image objImage = System.Drawing.Image.FromStream(stream);
            //w = objImage.Width;
            //h = objImage.Height;
        }

        private void limparCampos()
        {
            txtGrupo.Text = "";
            txtLink.Text = "";
            txtNome.Text = "";
            cmbCategoria.SelectedIndex = -1;
        }

        protected void gridAplicativos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Deletar")
            {
                int _index = int.Parse((string)e.CommandArgument);
                string chave = gridAplicativos.DataKeys[_index]["IdAplicativo"].ToString();

                AplicativoDTO dto = new AplicativoDTO();
                dto.idAplicativo = int.Parse(chave);

                AplicativoBRL brl = new AplicativoBRL();
                if (brl.deleteAplicativo(dto))
                    Response.Redirect("AddAplicativo.aspx?id=deletado");
            }
        }
    }
}