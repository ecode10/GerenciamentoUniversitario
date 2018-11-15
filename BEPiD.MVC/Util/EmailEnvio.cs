using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.Util
{
    public static class EmailEnvio
    {

        public static void enviaEmail(string[] emailPara, string subject, string message)
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



        public static void enviaEmail(string De, string[] emailPara, string mensagem, string titulo)
        {
            SmtpClient cliente = new SmtpClient();
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;

            System.Net.NetworkCredential credentials = new NetworkCredential("bepiducb@gmail.com", "catolica2014");
            cliente.UseDefaultCredentials = true;
            cliente.Credentials = credentials;

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("bepiducb@gmail.com");

            for (int i = 0; i < emailPara.Length; i++)
            {
                msg.To.Add(new MailAddress(emailPara[i]));
            }


            msg.Subject = titulo;
            msg.IsBodyHtml = true;
            msg.Body = string.Format("<html><head><img src='http://www.bepiducb.com.br/img/Untitled-2.png' width='150'/><br></head><body>" + De + "<br>" + mensagem + "</b></body>");

            try
            {
                cliente.Send(msg);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void SendSimpleMessage(string aluno, string email)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"<img src='http://www.bepiducb.com.br/img/Untitled-2.png' width='150' alt='BEPiD UCB'/> <br><br>");
            str.Append(@"Prezado(a) aluno(a) " + aluno);
            str.Append(@"<br><Br>
Informamos que o <B>Processo seletivo 2017 do BEPiD (Brazilian Education Program for iOS Developer) está aberto
em Brasília/DF vinculado a Universidade Católica. Acesse o site <a href='http://www.bepiducb.com.br'>www.bepiducb.com.br</a>,
leia o edital e faça a sua inscrição. Em caso de dúvidas, favor entre em contato conosco através de nosso site.<br><Br>
Coordenação do Projeto BEPiD");

            // Compose a message
            MailMessage mail = new MailMessage("bepid@mauriciojunior.org", email);
            mail.Subject = "Processo Seletivo Aberto para o BEPiD 2017";
            mail.Body = str.ToString();
            mail.IsBodyHtml = true;

            // Send it!
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("bepid@ecode10.com", "[cmjunior]");
            client.Host = "smtp.mailgun.org";

            client.Send(mail);
        }

        public static void SendSimpleMessage(string aluno, string email, string mensagem, string assunto)
        {
            StringBuilder str = new StringBuilder();
            //str.Append(@"<img src='http://www.bepiducb.com.br/img/Untitled-2.png' width='150' alt='BEPiD UCB'/> <br><br>");
            //str.Append(@"Prezado(a) aluno(a) " + aluno);
            str.Append(@"<br><Br>");
            str.Append(mensagem);

            // Compose a message
            MailMessage mail = new MailMessage("bepid@admin.bepiducb.com.br", email);
            mail.Subject = assunto;
            mail.Body = str.ToString();
            mail.IsBodyHtml = true;

            // Send it!
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("bepid@ecode10.com", "[cmjunior]");
            client.Host = "smtp.mailgun.org";

            client.Send(mail);
        }
    }
}
