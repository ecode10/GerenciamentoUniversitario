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
    public partial class DetailUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
           

            if (!Page.IsPostBack)
            {
                //if (Session["IdUsuarioDetalhe"].ToString().Equals("") || Session["IdUsuarioDetalhe"]==null)
                    //Response.Redirect("AllUser");

                if (Request.Params["id"] != null)
                    preencherDados(Request.Params["id"].ToString());
                else
                    Response.Redirect("AllUser");
            }
        }

        private void preencherDados(String id)
        {
            AlunoDTO dto = new AlunoDTO();
            dto.idAluno = int.Parse(id);

            AlunoBRL brl = new AlunoBRL();
            this.grdAluno.DataSource = brl.searchDadosPrincipais(dto);
            this.grdAluno.DataBind();
        }

        //protected void cmdVoltar_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("AllUser");
        //}
    }
}