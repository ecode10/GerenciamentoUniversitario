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
    public partial class RelatorioFinanceiro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
           
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

        protected void grdAluno_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Nome")
            {
                int index = int.Parse((string)e.CommandArgument);
                int IdAluno = int.Parse(grdAluno.DataKeys[index]["IdAluno"].ToString());

                //Session.Add("IdUsuarioDetalhe", IdAluno.ToString());
                Response.Redirect("DetailUser?id=" + IdAluno.ToString());
            }
        }

        //protected void cmdExportar_Click(object sender, EventArgs e)
        //{
        //    Response.Clear();
        //    Response.Buffer = true;
        //    Response.ContentType = "application/ms-excel";
        //    Response.AddHeader("content-disposition", "attachment;filename=Relatorio.xls");
        //    Response.Charset = "";
        //    this.EnableViewState = false;
        //    System.IO.StringWriter os = new System.IO.StringWriter();
        //    System.Web.UI.HtmlTextWriter oh = new HtmlTextWriter(os);
        //    Response.Write(os);
        //    Response.End();
        //}
    }
}