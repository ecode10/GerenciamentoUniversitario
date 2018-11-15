using Amazon.S3.Model;
using Amazon.S3.Transfer;
using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD.Private
{
    public partial class AddAplicativo : System.Web.UI.Page
    {
        protected void Page_PreInit(Object sender, EventArgs e)
        {
            verificaProfessorOuAluno(1);

        }

        private void verificaProfessorOuAluno(int inicial)
        {
            if (Session["N"] == null)
            {
                Response.Redirect("/Private/Login");
            }

            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            //if (Session != null && !Session["S"].Equals("P"))
            if (Session["S"].Equals("A"))
            {
                this.MasterPageFile = "~/Logado.Master";
            }
            else if(Session["S"].Equals("P")) //P é para os professores
            {
                //pnlAdministrativo.Visible = true;
                this.MasterPageFile = "~/Adm.Master";
                //if (inicial == 0)
                //{
                    //grdDadosAluno.Visible = false;
                    //pnlFoto.Visible = false;
                    //pnlInformacao.Visible = false;
                    //lblTitulo.Text = "Área restrita a Professores.";
                //}
                //else
                    //this.MasterPageFile = "~/Adm.Master";

            }
        }

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

            if (Session["S"] != null)
            {
                AplicativoDTO dto = new AplicativoDTO();

                //verifica se é professor, se for pega todos os apps.
                if (Session["S"].Equals("A")) //diferente de P
                    dto.idAluno = int.Parse(Session["I"].ToString());

                AplicativoBRL brl = new AplicativoBRL();
                this.gridAplicativos.DataSource = brl.searchAplicativo(dto);
                this.gridAplicativos.DataBind();
            }
            else
            {
                Response.Redirect("Login");
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
                    _aplicativoDTO.idAluno = int.Parse(Session["I"].ToString());

                    //imagem
                     int tamanho = flImagem.PostedFile.ContentLength;

                     if (tamanho == 0)
                     {
                         lblResultado.Text = "Por favor envie a logomarca do aplicativo";
                         return;
                     }

                     if (tamanho <= 4000000)
                     {
                         string filename = System.IO.Path.GetFileName(flImagem.PostedFile.FileName);
                         filename = Guid.NewGuid() + filename;


                         TransferUtility fileTransferUtility = new
                             TransferUtility(System.Configuration.ConfigurationManager.AppSettings["AccessKey"].ToString(),
                                             System.Configuration.ConfigurationManager.AppSettings["SecretKey"].ToString());

                         var uploadRequest = new Amazon.S3.Transfer.TransferUtilityUploadRequest();
                         uploadRequest.InputStream = flImagem.PostedFile.InputStream;
                         uploadRequest.BucketName = "BEPiD";
                         uploadRequest.Key = filename;
                         uploadRequest.StorageClass = S3StorageClass.ReducedRedundancy;
                         uploadRequest.CannedACL = S3CannedACL.PublicRead;


                         fileTransferUtility.Upload(uploadRequest);

                         //lblImagem.Text = "<img src='http://s3.amazonaws.com/BEPiD/" + filename.ToString() + "' style='border-radius:30px;'/>";

                         string urlImagem = "http://s3.amazonaws.com/BEPiD/" + filename.ToString();
                         HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(urlImagem);
                         HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                         Stream stream = httpWebReponse.GetResponseStream();

                         System.Drawing.Image objImage = System.Drawing.Image.FromStream(stream);
                         int w = objImage.Width;
                         int h = objImage.Height;

                         if (w <= 120 && h <= 120)
                         {
                             _aplicativoDTO.imagemAplicativo = filename.ToString();
                         }
                     }
                     else
                     {
                         lblResultado.Text = "A imagem deve respeitar o tamanho informado. Dimensões: 120 x 120.";
                     }

                    AplicativoBRL _aplicativoBRL = new AplicativoBRL();
                    if (_aplicativoBRL.insertAplicativo(_aplicativoDTO))
                    {
                        Response.Redirect("AddAplicativo?id=sucesso");
                    }

                }
            }
            catch (Exception ex)
            {
                 throw ex;
            }
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