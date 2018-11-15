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

namespace admin.bepiducb.com.br.Private
{
    public partial class AllUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            //if (!Session["S"].Equals("P"))
            //    Response.Redirect("Login.aspx");

            if (!Page.IsPostBack)
            {
                preencherTipoAluno();
                //txtAno.Text = DateTime.Now.Year.ToString();
                //cmdBuscar_Click(sender, e);
            }
        }

        private void preencherTipoAluno()
        {
            BEPiD.Business.BRL.AlunoTipoBRL brl = new AlunoTipoBRL();
            cmbTipoAluno.DataSource = brl.searchAllTipo();
            cmbTipoAluno.DataTextField = "DescricaoTipoAluno";
            cmbTipoAluno.DataValueField = "IdTipoAluno";
            cmbTipoAluno.DataBind();

            cmbTipoAluno.Items.Insert(0, new ListItem("Selecione", ""));
        }

        //private void preencherGrid()
        //{
        //    AlunoBRL brl = new AlunoBRL();
        //    DataTable dt = brl.allUser();

        //    grdAluno.DataSource = dt;
        //    grdAluno.DataBind();

        //    //lblAlunos.Text = "Total de alunos cadastrados: " + dt.Rows.Count;

        //    calculaTotal(dt);
        //}

        private void calculaTotal(DataTable dt)
        {
            int _ativos = 0;
            int _inativos = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Situacao"].Equals("A"))
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

                //Session.Add("IdUsuarioDetalhe", IdAluno.ToString());
                Response.Redirect("DetailUser?id=" + IdAluno.ToString());
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

                if (!cmbTipoAluno.SelectedValue.Equals(""))
                    dto.idTipoAluno = int.Parse(cmbTipoAluno.SelectedValue.ToString());

                AlunoBRL brl = new AlunoBRL();
                DataTable dt = brl.searchAlunosGeral(dto);
                grdAluno.DataSource = dt;
                grdAluno.DataBind();

                calculaTotal(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //protected void grdAluno_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        StringBuilder str = new StringBuilder();

        //        Int32 _idTipoAluno = int.Parse(grdAluno.DataKeys[e.Row.RowIndex].Values[1].ToString());

        //        AlunoTipoDTO _alunoTipoDTO = new AlunoTipoDTO();
        //        _alunoTipoDTO.idTipoAluno = _idTipoAluno;

        //        AlunoTipoBRL _alunoTipoBRL = new AlunoTipoBRL();
        //        DataTable dtGrid = _alunoTipoBRL.searchByIdTipoAluno(_alunoTipoDTO);

        //        for (int i = 0; i < dtGrid.Rows.Count; i++)
        //        {
        //            if (i == dtGrid.Rows.Count)
        //                str.Append(dtGrid.Rows[i]["DescricaoTipoAluno"].ToString());
        //        }

        //        Label myLabel = e.Row.FindControl("lblAlunoTipo") as Label;
        //        myLabel.Text = str.ToString();

        //    }
        //}
    }
}