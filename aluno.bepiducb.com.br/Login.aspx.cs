using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Authentication;
using System.Web.Security;
using CriptQuery;

namespace aluno.bepiducb.com.br
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtUsuario.Focus();
            }
        }

        public void CriarCookie(string nome, string email, string idAluno,
                string situacao, string cpf)
        {
            try
            {
                Session.Add("IPAluno", Request.UserHostAddress.ToString());
                Session.Add("NAluno", nome);
                Session.Add("EAluno", email);
                Session.Add("IAluno", idAluno);
                Session.Add("SAluno", situacao);
                Session.Add("CAluno", cpf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected void cmdLogar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    AlunoDTO dto = new AlunoDTO();
                    dto.email = txtUsuario.Text;
                    dto.password = cript2.code.business.SimpleCripto.Encrypt(txtPass.Text + txtUsuario.Text.Substring(0, 2), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());
                    dto.ano = DateTime.Now.Year;

                    AlunoBRL brl = new AlunoBRL();
                    DataTable dtTable = brl.searchUserLogin(dto);

                    if (dtTable != null && dtTable.Rows.Count > 0)
                    {
                        string _nome = HttpUtility.UrlEncode(dtTable.Rows[0]["Nome"].ToString(), Encoding.GetEncoding(28597)).Replace("+", " ");

                        if (Request.QueryString["ReturnUrl"] == null)
                        {
                            CriarCookie(_nome,
                                        dtTable.Rows[0]["Email"].ToString(),
                                        dtTable.Rows[0]["IdAluno"].ToString(),
                                        dtTable.Rows[0]["Situacao"].ToString(),
                                        "");

                            FormsAuthentication.SetAuthCookie("webformAlunoAutentication", false);
                            Response.Redirect("/Alunos/Default", true);
                        }
                        else
                        {
                            FormsAuthentication.RedirectFromLoginPage("webformAutentication", true);
                        }
                    }
                    else
                    {
                        lblResultado.Text = "E-mail ou senha inválidos. <Br>Tente novamente ou entre em contato conosco.";
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void lnkEsqueceuASenha_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtUsuario.Text))
                    {
                        AlunoDTO dto = new AlunoDTO();
                        dto.email = txtUsuario.Text;
                        dto.situacao = "A";

                        AlunoBRL brl = new AlunoBRL();
                        DataTable dtEmail = brl.searchAlunoByEmail(dto);

                        if (dtEmail != null && dtEmail.Rows.Count > 0)
                        {
                            CriptQuery.SecureQueryString qs = new SecureQueryString();
                            qs["Email"] = txtUsuario.Text;
                            qs["Id"] = dtEmail.Rows[0]["IdAluno"].ToString();
                            //qs["Tipo"] = "Professor";


                            string[] emails = new string[1];
                            emails[0] = txtUsuario.Text;

                            //string _pw = cript2.code.business.SimpleCripto.Decrypt(dtEmail.Rows[0]["PWProfessor"].ToString(), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());

                            StringBuilder str = new StringBuilder();
                            str.Append(@" Segue o link abaixo para alterar a senha solicitada através do sistema BEPiD UCB. <br>
                                      Lembre-se de nunca passar a sua senha para ninguém, toda senha 
                                        é confidencial e intransferível. ");

                            str.Append(@" <Br><Br> Acesse o link ou copie cole no browser: http://aluno.bepiducb.com.br/LoginAlterarSenha?e=" + qs.ToString() + " <br> e digite nova senha.");
                            str.Append(@" <Br><Br> Em caso de dúvidas, entre em contato conosco pelo menu Contato");

                            BEPiD.Business.Util.EmailEnvio.enviaEmail(emails, "E-mail automático de senha - aluno.bepiducb.com.br", str.ToString());

                            lblResultado.Text = "Foi enviado para seu e-mail.";
                        }
                        else
                            lblResultado.Text = "O e-mail não está cadastrado, entrar em contato com o administrador.";
                    }
                    else
                    {
                        lblResultado.Text = "Favor, digite o seu e-mail no campo de e-mail para verificação!";
                        txtUsuario.Focus();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}