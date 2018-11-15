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
    public partial class InscricoesEnviadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            
            if (!Page.IsPostBack)
            {
                //txtAno.Text = "2015";
                //preencherGrid();
            }
        }

        private void preencherGrid()
        {
            AlunoDTO dto = new AlunoDTO();
            dto.nome = txtNome.Text;

            if (!String.IsNullOrEmpty(txtAno.Text))
                dto.ano = int.Parse(txtAno.Text);

            dto.sexo = cmbSexo.SelectedValue.ToString();
            dto.nomeUniversidade = cmbInstituicao.SelectedValue.ToString();

            if (!String.IsNullOrEmpty(cmbTipoAluno.SelectedValue.ToString()))
                dto.idTipoAluno = int.Parse(cmbTipoAluno.SelectedValue.ToString());

            dto.situacao = cmbSituacao.SelectedValue.ToString();

            AlunoBRL brl = new AlunoBRL();
            DataTable dt = brl.allUserInscricao(dto);
            grdAluno.DataSource = dt;
            grdAluno.DataBind();

            lblAlunos.Text = "Total de alunos cadastrados: " + dt.Rows.Count;

            //adicionando sessao para pegar na pagina de excel.-
            Session.Add("dtUsuario", dt);

            //ativa o botao para gerar o excel
            this.cmdGerarExcel.Visible = true;

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
                    preencherGrid();
            }
            else if (e.CommandName == "Ativar")
            {
                int index = int.Parse((string)e.CommandArgument);
                int IdAluno = int.Parse(grdAluno.DataKeys[index]["IdAluno"].ToString());

                dto.idAluno = IdAluno;
                dto.situacao = "A";

                AlunoBRL brl = new AlunoBRL();
                if (brl.updateAlunoSituacaoById(dto))
                    preencherGrid();
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

        

        private void geraExcel()
        {
            //var controle = Master.FindControl("masterPageNav");
            //if (controle != null)
            //    controle.Visible = false;

            //tablePrincipal.Visible = false;

            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=InscricoesBEPiD.xls");
            Response.ContentType = "application/vn.ms-excel";
            Response.Charset = "";
            this.EnableViewState = false;
            System.IO.StringWriter wStringWrite = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oHTML = new HtmlTextWriter(wStringWrite);
            Response.Write(wStringWrite.ToString());

            //tablePrincipal.Visible = true;
            //controle.Visible = true;
        }
    }
}