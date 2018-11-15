using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEPiD.Business.BRL;
using System.Data;
using System.Text;
using CriptQuery;
using System.Collections;

namespace BEPiD.Private
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                this.ClearApplicationCache();

                txtEmail.Focus();

                if (Request.Params["Id"] != null)
                {
                    if (Request.Params["Id"].Equals("P"))
                    {
                        hdProfessor.Value = "P";
                        lblTitulo.Text = "Área restrita ao professor.";
                    }
                    else if(Request.Params["Id"].Equals("A"))
                    {
                        hdProfessor.Value = "A";
                        lblTitulo.Text = "Área restrita do aluno.";
                    }
                }

                //apagando o cookie da máquina.
                //HttpCookie Session = new HttpCookie("BEPiDUCB.Site");
                //trinda dias para expirar
                //Session.Expires = DateTime.Now.AddDays(-1);
                //Response.AppendCookie(Session);
                //Response.Redirect("/Default");
            }
        }

        protected void cmdLogin_Click(object sender, EventArgs e)
        {
           // try
            //{
            if (Page.IsValid)
            {
                if (hdProfessor.Value.Equals("P"))
                {
                    ProfessorDTO dto = new ProfessorDTO();
                    dto.emailProfessor = txtEmail.Text;
                    dto.pwProfessor = cript2.code.business.SimpleCripto.Encrypt(txtPassword.Text + txtEmail.Text.Substring(0, 2), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());

                    ProfessorBRL brl = new ProfessorBRL();
                    DataTable dtTable = brl.searchProfessor(dto);

                    if (dtTable != null && dtTable.Rows.Count > 0)
                    {
                        string _nome = HttpUtility.UrlEncode(dtTable.Rows[0]["NomeProfessor"].ToString(), Encoding.GetEncoding(28597)).Replace("+", " ");
                        CriarCookie(_nome,
                                    dtTable.Rows[0]["EmailProfessor"].ToString(),
                                    dtTable.Rows[0]["IdProfessor"].ToString(),
                                    "P",
                                    "");

                        Response.Redirect("Dados.aspx");
                    }
                    else
                    {
                        lblResultado.Text = "E-mail ou senha inválidos. <Br>Tente novamente ou entre em contato conosco.";
                    }
                }
                else if(hdProfessor.Value.Equals("A"))
                {
                    AlunoDTO dto = new AlunoDTO();
                    dto.email = txtEmail.Text;
                    dto.password = cript2.code.business.SimpleCripto.Encrypt(txtPassword.Text + txtEmail.Text.Substring(0, 2), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());

                    AlunoBRL brl = new AlunoBRL();
                    DataTable dtTable = brl.searchUserLogin(dto);

                    if (dtTable != null && dtTable.Rows.Count > 0)
                    {
                        string _nome = HttpUtility.UrlEncode(dtTable.Rows[0]["Nome"].ToString(), Encoding.GetEncoding(28597)).Replace("+", " ");
                        CriarCookie(_nome,
                                    dtTable.Rows[0]["Email"].ToString(),
                                    dtTable.Rows[0]["IdAluno"].ToString(),
                                    "A",
                                    dtTable.Rows[0]["CPF"].ToString());

                        Response.Redirect("Dados.aspx");
                    }
                    else
                    {
                        lblResultado.Text = "E-mail ou senha inválidos. <Br>Tente novamente ou entre em contato conosco.";
                    }
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    enviaEmailError(txtEmail.Text, ex.ToString() + ex.StackTrace.ToString());
            //}
        }

        public void ClearApplicationCache()
        {
            List<string> keys = new List<string>();

            // retrieve application Cache enumerator
            IDictionaryEnumerator enumerator = Cache.GetEnumerator();

            // copy all keys that currently exist in Cache
            while (enumerator.MoveNext())
            {
                keys.Add(enumerator.Key.ToString());
            }

            // delete every key from cache
            for (int i = 0; i < keys.Count; i++)
            {
                Cache.Remove(keys[i]);
            }
        }
 

        private void enviaEmailError(String email, String error)
        {
            StringBuilder str = new StringBuilder();

            str.Append(@" O e-mail " + email + "  tentou acessar o site e deu erro. Error: " + error);

            string[] _emails = new string[1];
            _emails[0] = "mauricio.junior@ucb.br";

            BEPiD.Business.Util.EmailEnvio.enviaEmail("bepiducb@gmail.com",
                _emails, str.ToString(), "E-mail automático de error - www.bepiducb.com.br");
        }

        public void CriarCookie(string nome, string email, string idAluno,
                string situacao, string cpf)
        {
            try
            {
                Session.Add("IP", Request.UserHostAddress.ToString());
                Session.Add("N", nome);
                Session.Add("E", email);
                Session.Add("I", idAluno);
                Session.Add("S", situacao);
                Session.Add("C", cpf);
                //HttpCookie Session = new HttpCookie("BEPiDUCB.Site");
                //Session.Values.Add("IP", Request.UserHostAddress.ToString());
                //Session.Values.Add("N", nome);
                //Session.Values.Add("E", email);
                //Session.Values.Add("I", idAluno);
                //Session.Values.Add("S", situacao);
                //Session.Values.Add("C", cpf);

                //trinda dias para expirar
                //Session.Expires = DateTime.Now.AddDays(1);
                //Session.Timeout = DateTime

                //Response.AppendCookie(Session);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void cmdEsqueceu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtEmail.Text))
                {

                    if (hdProfessor.Value.Equals("S"))
                    {
                        ProfessorDTO dto = new ProfessorDTO();
                        dto.emailProfessor = txtEmail.Text;

                        ProfessorBRL brl = new ProfessorBRL();
                        DataTable dtEmail = brl.searchProfessorByEmail(dto);

                        if (dtEmail != null && dtEmail.Rows.Count > 0)
                        {
                            CriptQuery.SecureQueryString qs = new SecureQueryString();
                            qs["Email"] = txtEmail.Text;
                            qs["Id"] = dtEmail.Rows[0]["IdProfessor"].ToString();
                            qs["Tipo"] = "Professor";


                            string[] emails = new string[1];
                            emails[0] = txtEmail.Text;

                           //string _pw = cript2.code.business.SimpleCripto.Decrypt(dtEmail.Rows[0]["PWProfessor"].ToString(), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());

                            StringBuilder str = new StringBuilder();
                            str.Append(@" Segue o link abaixo para alterar a senha solicitada através do sistema BEPiD UCB. <br>
                                      Lembre-se de nunca passar a sua senha para ninguém, toda senha 
                                        é confidencial e intransferível. ");

                            str.Append(@" <Br><Br> Acesse o link ou copie cole no browser: http://www.bepiducb.com.br/private/LoginAlterarSenha?e=" + qs.ToString() + " <br> e digite nova senha.");
                            str.Append(@" <Br><Br> Em caso de dúvidas, entre em contato conosco pelo menu Contato");

                            BEPiD.Business.Util.EmailEnvio.enviaEmail("bepiducb@gmail.com", emails, str.ToString(), "E-mail automático de senha - www.bepiducb.com.br");

                            lblResultado.Text = "Foi enviado para seu e-mail.";
                        }
                        else
                            lblResultado.Text = "O e-mail não está cadastrado, entrar em contato com o administrador.";
                    }
                    else
                    {
                        AlunoDTO dto = new AlunoDTO();
                        dto.email = txtEmail.Text;

                        AlunoBRL brl = new AlunoBRL();
                        DataTable dtEmail = brl.searchAlunoByEmail(dto);

                        if (dtEmail != null && dtEmail.Rows.Count > 0)
                        {
                            CriptQuery.SecureQueryString qs = new SecureQueryString();
                            qs["Email"] = txtEmail.Text;
                            qs["Id"] = dtEmail.Rows[0]["IdAluno"].ToString();
                            qs["Tipo"] = "Aluno";

                            string[] emails = new string[1];
                            emails[0] = txtEmail.Text;

                            //string _pw = cript2.code.business.SimpleCripto.Decrypt(dtEmail.Rows[0]["Password"].ToString(), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());

                            StringBuilder str = new StringBuilder();
                            str.Append(@" Segue o link abaixo para alterar a senha solicitada através do sistema BEPiD UCB. <br>
                                      Lembre-se de nunca passar a sua senha para ninguém, toda senha 
                                        é confidencial e intransferível. ");

                            str.Append(@" <Br><Br> Acesse o link ou copie cole no browser: http://www.bepiducb.com.br/private/LoginAlterarSenha?e=" + qs.ToString() + " <br> e digite nova senha.");
                            str.Append(@" <Br><Br> Em caso de dúvidas, entre em contato conosco pelo menu Contato");

                            BEPiD.Business.Util.EmailEnvio.enviaEmail("bepiducb@gmail.com", emails, str.ToString(), "E-mail automático de senha - www.bepiducb.com.br");

                            lblResultado.Text = "Foi enviado para seu e-mail.";
                        }
                        else
                            lblResultado.Text = "O e-mail não está cadastrado, entrar em contato com o administrador.";
                    }
                }
                else
                {
                    lblResultado.Text = "Favor, digite o seu e-mail no campo de e-mail para verificação!";
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}