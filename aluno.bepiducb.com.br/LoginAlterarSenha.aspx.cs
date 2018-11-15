using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using CriptQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aluno.bepiducb.com.br
{
    public partial class LoginAlterarSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string chave = Request.Params["e"];
                if (Request.Params["e"] != "")
                {
                    try
                    {
                        CriptQuery.SecureQueryString qs = new SecureQueryString(Request["e"]);

                        string Email = qs["Email"];
                        string Id = qs["Id"];

                        //atribuindo as variaveis locais
                        hdEmail.Value = Email;
                        hdId.Value = Id;
                    }
                    catch (CriptQuery.ExpiredQueryStringException)
                    {
                        lblResultado.Text = "Sua chave foi expirada. <Br> Por favor fale com a administração do site.";
                        desabilitaCampos();
                        return;
                    }
                    catch (CriptQuery.InvalidQueryStringException)
                    {
                        lblResultado.Text = "Sua chave é inválida ou está corrompida. <br> Favor fale com a administração do site.";
                        desabilitaCampos();
                        return;
                    }
                }
                else
                {
                    lblResultado.Text = "Atenção: Favor coloque a chave corretamente.";
                }
            }
        }

        protected void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoDTO dto = new AlunoDTO();
                dto.password = cript2.code.business.SimpleCripto.Encrypt(txtPassword.Text + hdEmail.Value.Substring(0, 2), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());

                if (!String.IsNullOrEmpty(hdId.Value))
                    dto.idAluno = int.Parse(hdId.Value);

                dto.email = hdEmail.Value;
                dto.situacao = "A";

                AlunoBRL brl = new AlunoBRL();
                if (brl.updateAlunoSenhaByEmaileId(dto))
                {
                    lblResultado.Text = "Senha alterada com sucesso. <br>Favor acessar o link <a href='Login'>Login</a> para entrar no sistema.";
                    desabilitaCampos();
                }
                else
                    lblResultado.Text = "Erro ao tentar mudar a senha, entrar em contato com o administrador";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Erro aconteceu. <br> " + ex.ToString();
            }

        }

        private void desabilitaCampos()
        {
            txtPassword.Visible = false;
            txtPasswordRepetido.Visible = false;
            cmdLogin.Visible = false;
            lblRepetirSenha.Visible = false;
            lblSenha.Visible = false;
        }
    }
}