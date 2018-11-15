using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEPiD.Business.DTO;
using BEPiD.Business.BRL;
using System.Text;

namespace BEPiD
{
    public partial class AddProfessor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtNome.Focus();
                Response.Redirect("Default");
            }
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    ProfessorDTO dto = new ProfessorDTO();
                    dto.nomeProfessor = txtNome.Text;
                    dto.emailProfessor = txtEmail.Text;
                    dto.pwProfessor = cript2.code.business.SimpleCripto.Encrypt(txtPW.Text + txtEmail.Text.Substring(0, 2), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());

                    ProfessorBRL brl = new ProfessorBRL();
                    if (brl.insertMaquina(dto))
                    {
                        lblResultado.Text = "Professor inserido com sucesso.";

                        txtEmail.Text = "";
                        txtNome.Text = "";
                        txtPW.Text = "";

                        //enviando e-mail de cadastro
                        enviadEmailAdministradores();

                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void enviadEmailAdministradores()
        {
         
            StringBuilder str = new StringBuilder();

            str.Append(@" O professor " + txtNome.Text +
                " acaba de se cadastrar no sistema BEPiD UCB. <br>E-mail: " + txtEmail.Text);

            string[] _emails = new string[1];
            _emails[0] = "mauricio.junior@ucb.br";

            BEPiD.Business.Util.EmailEnvio.enviaEmail("bepiducb@gmail.com",
                _emails, str.ToString(), "E-mail automático de cadastro de professor - www.bepiducb.com.br");
      
        }
    }
}