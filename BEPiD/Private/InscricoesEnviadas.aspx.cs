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

namespace BEPiD.Private
{
    public partial class InscricoesEnviadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (!Session["S"].Equals("P"))
                Response.Redirect("Login.aspx");

            if (!Page.IsPostBack)
            {
                //txtAno.Text = "2015";
                preencherGrid();
            }
        }

        private void preencherGrid()
        {
            AlunoDTO dto = new AlunoDTO();
            dto.nome = txtNome.Text;
            dto.ano = int.Parse(txtAno.Text);
            dto.sexo = cmbSexo.SelectedValue.ToString();
            dto.nomeUniversidade = cmbInstituicao.SelectedValue.ToString();

            AlunoBRL brl = new AlunoBRL();
            DataTable dt = brl.allUserInscricao(dto);
            grdAluno.DataSource = dt;
            grdAluno.DataBind();

            lblAlunos.Text = "Total de alunos cadastrados: " + dt.Rows.Count;

            //calculaTotal(dt);
        }

        private void calculaTotal(DataTable dt)
        {
            int _ativos = 0;
            int _inativos = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Situacao"].Equals("P"))
                    _ativos++;

                if (dt.Rows[i]["Situacao"].Equals("I"))
                    _inativos++;
            }

            StringBuilder str = new StringBuilder();
            str.Append(@" Total geral de alunos: " + dt.Rows.Count);
            str.Append(@" <br>Total ativos: " + _ativos);
            str.Append(@" <br>Total inativos:  " + _inativos);
            lblAlunos.Text = str.ToString();
        }

        protected void grdAluno_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AlunoDTO dto = new AlunoDTO();

            if (e.CommandName == "Inativar")
            {
                int index = int.Parse((string)e.CommandArgument);
                int IdAluno = int.Parse(grdAluno.DataKeys[index]["IdAluno"].ToString());

                dto.idAluno = IdAluno;
                dto.situacao = "I";

                AlunoBRL brl = new AlunoBRL();
                if (brl.updateAlunoSituacaoById(dto))
                    Response.Redirect("AllUser");
            }
            else if (e.CommandName == "Ativar")
            {
                int index = int.Parse((string)e.CommandArgument);
                int IdAluno = int.Parse(grdAluno.DataKeys[index]["IdAluno"].ToString());

                dto.idAluno = IdAluno;
                dto.situacao = "A";

                AlunoBRL brl = new AlunoBRL();
                if (brl.updateAlunoSituacaoById(dto))
                    Response.Redirect("AllUser");
            }
            else if (e.CommandName == "Nome")
            {
                int index = int.Parse((string)e.CommandArgument);
                int IdAluno = int.Parse(grdAluno.DataKeys[index]["IdAluno"].ToString());

                Session.Add("IdUsuarioDetalhe", IdAluno.ToString());
                Response.Redirect("DetailUser");
            }
        }

        protected void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                preencherGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdAluno_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grdAluno.PageIndex = e.NewPageIndex;
            preencherGrid();
        }
    }
}