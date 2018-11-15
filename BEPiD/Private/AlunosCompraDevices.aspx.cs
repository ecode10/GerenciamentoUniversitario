using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEPiD.Business.BRL;
using BEPiD.Business.DTO;

namespace BEPiD.Private
{
    public partial class AlunosCompraDevices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (!Session["S"].Equals("P"))
                Response.Redirect("Login.aspx");


            if (!Page.IsPostBack)
            {
                txtAno.Focus();
            }

        }

        protected void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoDTO dto = new AlunoDTO();

                if (txtAno.Text.Length > 0)
                    dto.ano = int.Parse(txtAno.Text);

                dto.situacao = cmbSituacao.SelectedValue.ToString();

                AlunoBRL brl = new AlunoBRL();
                grdAluno.DataSource = brl.searchAlunosCompraDevices(dto);
                grdAluno.DataBind();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}