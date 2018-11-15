using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD2017
{
    public partial class AppsPublicadosDetalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null)
            {
                var _idAplicativo = Request.Params["id"].ToString();

                BEPiD.Business.DTO.AplicativoDTO dto = new BEPiD.Business.DTO.AplicativoDTO();
                dto.idAplicativo = int.Parse(_idAplicativo);

                BEPiD.Business.BRL.AplicativoBRL brl = new BEPiD.Business.BRL.AplicativoBRL();
                DataTable dtTable = brl.searchAplicativo(dto);
                this.gridAplicativos.DataSource = dtTable;
                this.gridAplicativos.DataBind();
            }
        }

        protected void cmdVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AppsPublicados");
        }
    }
}