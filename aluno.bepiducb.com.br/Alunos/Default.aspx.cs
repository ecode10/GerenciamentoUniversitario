using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aluno.bepiducb.com.br.Alunos
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["NAluno"] == null)
            {
                Response.Redirect("/Login");
            }

            if (!Page.IsPostBack)
            {
                Response.Cache.SetCacheability(HttpCacheability.NoCache);

                lblTitulo.Text = "Seja bem vindo(a) aluno(a) " + Session["NAluno"].ToString() + " ao sistema do BEPiD UCB.";
                //preencherGridAluno();
            }
        }
    }
}