using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin.bepiducb.com.br.Private
{
    public partial class InscricoesExcel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                preencheGrid(); 
                geraExcel();
            }
        }

        private void preencheGrid()
        {
           // AlunoDTO dto = new AlunoDTO();
           // dto.situacao = "P";
           // dto.ano = 2015;

           //// this.gridAluno.Attributes["style"] = @"mso-number-format:'\@'";

           // AlunoBRL brl = new AlunoBRL();
           // DataTable dt = brl.searchAlunoInscricao(dto);

            this.gridAluno.DataSource = (DataTable)Session["dtUsuario"];
            this.gridAluno.DataBind();

        }

        private void geraExcel()
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=Inscricoes.xls");
            Response.ContentType = "application/vn.ms-excel";
            Response.Charset = "";
            this.EnableViewState = false;
            System.IO.StringWriter wStringWrite = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oHTML = new HtmlTextWriter(wStringWrite);
            Response.Write(wStringWrite.ToString());

            Session["dtUsuario"] = "";
        }

        protected void gridAluno_DataBound(object sender, EventArgs e)
        {

        }

        protected void gridAluno_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[9].Attributes["style"] = @"mso-number-format:'\@'";
                e.Row.Cells[9].Text = "\t" + e.Row.Cells[9].Text;
            }
        }

        
    }
}