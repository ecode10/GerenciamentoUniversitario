using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin.bepiducb.com.br.Private
{
	public partial class MaquinaDelete : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Request.Params["Id"] != null && Request.Params["IdAluno"] != null)
            {
                BEPiD.Business.DTO.MaquinaDTO dto = new BEPiD.Business.DTO.MaquinaDTO();
                dto.idAluno = int.Parse(Request.Params["IdAluno"].ToString());
                dto.idMaquina = int.Parse(Request.Params["Id"].ToString());

                BEPiD.Business.BRL.MaquinaBRL maquina = new BEPiD.Business.BRL.MaquinaBRL();
                if (maquina.deleteMaquina(dto))
                {
                    Response.Redirect("Maquinas.aspx?Id=" + Request.Params["IdAluno"].ToString());
                }
            }
		}
	}
}