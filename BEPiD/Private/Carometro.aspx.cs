using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD.Private
{
    public partial class Carometro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (!Session["S"].Equals("P"))
                Response.Redirect("Login.aspx");

            if (!Page.IsPostBack)
            {
                //preencherGrid();
                preencheComboProfessores();

                //txtAno.Text = DateTime.Now.Year.ToString();
            }
        }

        private void preencheComboProfessores()
        {
            ProfessorBRL brl = new ProfessorBRL();
            this.cmbProfessores.DataSource = brl.allProfessor();

            this.cmbProfessores.DataTextField = "NomeProfessor";
            this.cmbProfessores.DataValueField = "IdProfessor";
            this.cmbProfessores.DataBind();

            this.cmbProfessores.Items.Insert(0, new ListItem("Selecione", "0"));

        }

        private void preencherGrid()
        {
            AlunoBRL brl = new AlunoBRL();
            DataTable dt = brl.allUser();
            grdAluno.DataSource = dt;
            grdAluno.DataBind();
        }
        protected void grdAluno_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AlunoDTO dto = new AlunoDTO();

            if (e.CommandName == "Nome")
            {
                int index = int.Parse((string)e.CommandArgument);
                int IdAluno = int.Parse(grdAluno.DataKeys[index]["IdAluno"].ToString());

                Session.Add("IdAluno", IdAluno.ToString());
                Response.Redirect("CarometroDetail");
            }
        }

        protected void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoDTO dto = new AlunoDTO();

                if (txtNome.Text.Length > 0)
                    dto.nome = txtNome.Text;

                if (txtAno.Text.Length > 0)
                    dto.ano = int.Parse(txtAno.Text);

                if (!cmbSituacao.SelectedValue.Equals(""))
                    dto.situacao = cmbSituacao.SelectedValue.ToString();

                if (!cmbProfessores.SelectedValue.Equals("0"))
                    dto.idProfessor = int.Parse(cmbProfessores.SelectedValue.ToString());

                if (!cmbAvaliacao.SelectedValue.Equals(""))
                    dto.tipoAvaliacao = cmbAvaliacao.SelectedValue.ToString();

                AlunoBRL brl = new AlunoBRL();
                DataTable dt = brl.searchAlunosGeral(dto);
                grdAluno.DataSource = dt;
                grdAluno.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}