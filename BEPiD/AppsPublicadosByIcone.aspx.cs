using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD
{
    public partial class AppsPublicadosByIcone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                preencherGrid(0);
            }
        }
        private void preencherGrid(int idCategoria)
        {
            AplicativoDTO dto = new AplicativoDTO();

            if (idCategoria != 0)
            {
                dto.idCategoria = idCategoria;
            }

            AplicativoBRL brl = new AplicativoBRL();
            DataTable dt = brl.searchAplicativo(dto);

            this.dtAplicativos.DataSource = dt;
            this.dtAplicativos.DataBind();
        }

    }
}