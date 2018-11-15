using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEPiD.Business.DTO;
using BEPiD.Business.BRL;
using System.Data;

namespace BEPiD.Private
{
    public partial class CarometroDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (!Session["S"].Equals("P"))
                Response.Redirect("Login.aspx");

            if (!Page.IsPostBack)
            {
                preencherGridAluno();
                preencherGridAvalicao();
                preencherContador();
            }

        }

        private void preencherContador()
        {
            AvaliacaoDTO dto = new AvaliacaoDTO();
            dto.idAluno = int.Parse(hdIdAluno.Value);

            AvaliacaoBRL brl = new AvaliacaoBRL();
            gridAvaliacaoContador.DataSource = brl.searchCountAvaliacao(dto);
            gridAvaliacaoContador.DataBind();
        }

        private void preencherGridAvalicao()
        {
            AvaliacaoDTO avalicacaoDTO = new AvaliacaoDTO();
            avalicacaoDTO.idAluno = int.Parse(hdIdAluno.Value);

            AvaliacaoBRL avalicacaoBRL = new AvaliacaoBRL();
            gridAvaliacao.DataSource = avalicacaoBRL.searchAvaliacaoByIdAluno(avalicacaoDTO);
            gridAvaliacao.DataBind();
        }

        private void preencherGridAluno()
        {
            hdIdAluno.Value = Session["IdAluno"].ToString();

            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            hdIdProfessor.Value = Session["I"].ToString();

            AlunoDTO dto = new AlunoDTO();
            dto.idAluno = int.Parse(hdIdAluno.Value);

            AlunoBRL brl = new AlunoBRL();
            DataTable dt = brl.searchDadosPrincipais(dto);
            grdAluno.DataSource = dt;
            grdAluno.DataBind();
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                AvaliacaoDTO dto = new AvaliacaoDTO();
                dto.dataAvaliacao = Convert.ToDateTime(BEPiD.Business.Util.Data.formataDataMMDDYYYY(txtDataAvaliacao.Text));
                dto.assuntoAvaliacao = cmbAssunto.SelectedValue.ToString();
                dto.mensagemAvaliacao = txtMensagem.Text;
                dto.tipoAvaliacao = cmbTipo.SelectedValue.ToString();
                dto.idAluno = int.Parse(hdIdAluno.Value);
                dto.idProfessor = int.Parse(hdIdProfessor.Value);

                AvaliacaoBRL brl = new AvaliacaoBRL();
                if (brl.insertMaquina(dto))
                {
                    lblResultado.Text = "Inserido com sucesso";
                    limparCampos();
                    preencherGridAvalicao();
                    preencherContador();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void limparCampos()
        {
            txtDataAvaliacao.Text = "";
            txtMensagem.Text = "";
            cmbAssunto.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            
        }

        protected void gridAvaliacao_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridAvaliacao.PageIndex = e.NewPageIndex;
            preencherGridAvalicao();
        }

        protected void cmdVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carometro");
        }
    }
}