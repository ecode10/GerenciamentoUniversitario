using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD2017
{
    public partial class VerificaInscricao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblResultado.Text = "";
                txtCPF.Text = "";

                txtCPF.Focus();
            }
        }

        protected void cmdVerificar_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                try
                {
                    AlunoDTO dto = new AlunoDTO();
                    dto.ano = DateTime.Now.Year + 1;
                    dto.cpf = txtCPF.Text.Replace(".", "").Replace("-", "");

                    AlunoBRL brl = new AlunoBRL();
                    var dtAluno = brl.searchAlunoByCPF(dto);

                    if (dtAluno != null && dtAluno.Rows.Count > 0)
                    {
                        lblResultado.ControlStyle.ForeColor = System.Drawing.Color.Blue;
                        lblResultado.Text = "PARABÉNS: Seu CPF está cadastrado no processo seletivo.";
                    }
                    else
                    {
                        lblResultado.ControlStyle.ForeColor = System.Drawing.Color.Red;
                        lblResultado.Text = "Seu CPF não está cadastrado no processo seletivo do ano " + dto.ano;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    lblResultado.Visible = true;
                }
            }
        }
    }
}