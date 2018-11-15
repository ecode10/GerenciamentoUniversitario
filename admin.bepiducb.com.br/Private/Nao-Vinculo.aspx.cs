using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin.bepiducb.com.br.Private
{
    public partial class Nao_Vinculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

            if (Session == null || Session["I"].ToString().Equals("0"))
                Response.Redirect("Login");

          
        }

        protected void cmdImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

                AlunoDTO dto = new AlunoDTO();
                dto.idAluno = int.Parse(Session["I"].ToString());
                dto.aceiteContrato = "S";

                AlunoBRL brl = new AlunoBRL();
                brl.updateAlunoAceiteOutorga(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void cmdGerarWord_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/msword";
            Response.Charset = "";
            this.EnableViewState = false;
            System.IO.StringWriter os = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oh = new HtmlTextWriter(os);
            Response.Write(os);
        }
    }
}