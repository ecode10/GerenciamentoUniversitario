using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtNome.Focus();
            }
        }

        protected void cmdLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Contact");
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            if (Page.IsValid)
            {
                try
                {
                    str.Append(@" Nome: " + txtNome.Text + "<Br> E-mail:" + txtEmail.Text +
                        "<br> Descrição: " + txtDescricao.Text);

                    string[] _emails = new string[4];
                    _emails[0] = "braga@ucb.br";
                    //_emails[1] = "hartmann@ucb.br";
                    _emails[1] = "jairab@yahoo.com.br";
                    _emails[2] = "moresi@ucb.br";
                    _emails[3] = "mauricio.analista@yahoo.com";


                    BEPiD.Business.Util.EmailEnvio.enviaEmail("bepiducb@gmail.com",
                        _emails, str.ToString(), "Dúvidas: enviado pelo site www.bepiducb.com.br");

                    txtDescricao.Text = "";
                    txtEmail.Text = "";
                    txtNome.Text = "";

                    lblResultado.Text = "E-mail enviado com sucesso, responderemos mais breve possível.";

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}