using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEPiD.Business.BRL;
using BEPiD.Business.DTO;

namespace BEPiD2017
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //preenche o datalist mostrando a quantidade de apps publicados em cada categoria
                preencherDataListQuantidade();
            }
        }

        private void preencherDataListQuantidade()
        {
            AplicativoBRL _aplicativoBRL = new AplicativoBRL();
            this.dtListViewQuantidadeApps.DataSource = _aplicativoBRL.searchAplicativoByCategoria();
            this.dtListViewQuantidadeApps.DataBind();
        }
    }
}