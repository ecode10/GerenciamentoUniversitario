using BEPiD.Business.BRL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin.bepiducb.com.br.Private
{
    public partial class AllMachine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
           

            if (!Page.IsPostBack)
            {
                preencherGridMaquina();
            }
        }

        private void preencherGridMaquina()
        {
            MaquinaBRL brl = new MaquinaBRL();
            grdMaquinas.DataSource = brl.allMachines();
            grdMaquinas.DataBind();
        }
    }
}