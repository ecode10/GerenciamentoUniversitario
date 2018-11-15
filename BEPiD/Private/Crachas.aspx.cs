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
    public partial class Crachas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (!Session["S"].Equals("P"))
                Response.Redirect("Login.aspx");

            if (!Page.IsPostBack)
            {
                txtAno.Text = DateTime.Now.Year.ToString();
                //preencherGrid();

                
            }
        }

        private void preencherGrid()
        {
            AlunoBRL alunoBRL = new AlunoBRL();
            this.grdAluno.DataSource =  alunoBRL.allUser();
            this.grdAluno.DataBind();
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