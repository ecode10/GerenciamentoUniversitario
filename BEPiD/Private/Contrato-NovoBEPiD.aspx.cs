using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD.Private
{
    public partial class Contrato_NovoBEPiD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

                if (Session == null || Session["I"].ToString().Equals("0"))
                {
                    Response.Redirect("Login");
                }
                else
                {
                    int idAluno = int.Parse(Session["I"].ToString());

                    AlunoDTO dto = new AlunoDTO();
                    dto.idAluno = idAluno;

                    BEPiD.Business.BRL.AlunoBRL alunoBRL = new Business.BRL.AlunoBRL();
                    DataTable dtAluno = alunoBRL.searchDadosPrincipais(dto);

                    if (dtAluno != null && dtAluno.Rows.Count > 0)
                    {
                        Session.Add("Endereco", dtAluno.Rows[0]["endereco"].ToString());
                        Session.Add("Cidade", dtAluno.Rows[0]["cidade"].ToString());
                        Session.Add("Estado", dtAluno.Rows[0]["Estado"].ToString());
                        Session.Add("CEP", dtAluno.Rows[0]["CEP"].ToString());
                        Session.Add("Identidade", dtAluno.Rows[0]["Identidade"].ToString());
                        Session.Add("Orgao", dtAluno.Rows[0]["orgao"].ToString());
                        Session.Add("Nacionalidade", dtAluno.Rows[0]["Nacionalidade"].ToString());
                        Session.Add("EstadoCivil", dtAluno.Rows[0]["EstadoCivil"].ToString());
                    }
                }
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