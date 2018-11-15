using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD2017
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static void SendEmail(string[] emailPara, string subject, string message)
        {

            var msg = new MailMessage();
            var smtpClient = new SmtpClient("smtp.bepiducb.com.br", 587);

            msg.From = new MailAddress("inscricoes@bepiducb.com.br");

            for (int i = 0; i < emailPara.Length; i++)
            {
                if (i == 0)
                    msg.To.Add(new MailAddress(emailPara[i]));

                if (i > 0)
                    msg.CC.Add(new MailAddress(emailPara[i]));
            }

            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;

            msg.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            msg.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");

            var loginInfo = new NetworkCredential("inscricoes@bepiducb.com.br", "G52-xg9-s6d-veT");
            smtpClient.EnableSsl = false;
            //smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = loginInfo;
            try
            {
                smtpClient.Send(msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                msg.Dispose();
            }
        }

        protected void txtEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    string[] _emails = new string[3];
                    _emails[0] = "bepiducb@gmail.com";
                    _emails[1] = "mauricio.analista@yahoo.com";
                    _emails[2] = "jairab@yahoo.com.br";

                    //msg.Body = string.Format("<html><head><img src='http://www.bepiducb.com.br/images/bepiducb_logo.png' width='150'/><br></head><body>" + De + "<br>" + mensagem + "</b></body>");
                    SendEmail(_emails, "Dúvida do site www.bepiducb.com.br", "<img src='http://www.bepiducb.com.br/img/images/bepiducb_logo.png' width='150'/><br>Nome: " + txtNome.Text + "<Br>Email: " + txtEmail.Text + "<br>Descrição: " + txtDescricao.Text);

                    txtEmail.Text = "";
                    txtDescricao.Text = "";
                    txtNome.Text = "";
                    lblResultado.Text = "Email enviado com sucesso, responderemos em breve.";
                    lblResultado.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<br><Br><br>Ops, um erro aconteceu: " + ex.Message.ToString());
                throw ex;

            }
        }
    }
}