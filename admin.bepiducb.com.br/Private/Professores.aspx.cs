using BEPiD.Business.BRL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin.bepiducb.com.br.Private
{
    public partial class Professores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
           

            if (!Page.IsPostBack)
            {
                preencherGrid();
            }
        }

        private void preencherGrid()
        {
            ProfessorBRL brl = new ProfessorBRL();
            this.grdAluno.DataSource = brl.allProfessor();
            this.grdAluno.DataBind();
        }
    }
}