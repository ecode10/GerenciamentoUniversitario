using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin.bepiducb.com.br.Private
{
    public partial class Instrumento_Particular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

            //if (Session == null || Session["I"].ToString().Equals("0"))
            if(Session==null)
                Response.Redirect("Login");
            else
            {
                //int idAluno = int.Parse(Session["I"].ToString());
                int idAluno = int.Parse(Request.Params["id"].ToString());

                AlunoDTO dto = new AlunoDTO();
                dto.idAluno = idAluno;

                BEPiD.Business.BRL.AlunoBRL alunoBRL = new BEPiD.Business.BRL.AlunoBRL();
                DataTable dtAluno = alunoBRL.searchDadosPrincipais(dto);

                if (dtAluno != null && dtAluno.Rows.Count > 0)
                {
                    Session.Add("Endereco", dtAluno.Rows[0]["endereco"].ToString());
                    Session.Add("Cidade", dtAluno.Rows[0]["cidade"].ToString());
                    Session.Add("Identidade", dtAluno.Rows[0]["Identidade"].ToString());
                    Session.Add("Orgao", dtAluno.Rows[0]["orgao"].ToString());
                    Session.Add("Nacionalidade", dtAluno.Rows[0]["Nacionalidade"].ToString());
                    Session.Add("EstadoCivil", dtAluno.Rows[0]["EstadoCivil"].ToString());
                    Session.Add("CEP", dtAluno.Rows[0]["CEP"].ToString());
                    Session.Add("N", dtAluno.Rows[0]["Nome"].ToString());
                    Session.Add("C", dtAluno.Rows[0]["CPF"].ToString());

                    //buscando as máquinas
                    MaquinaDTO dtoMaquina = new MaquinaDTO();
                    dtoMaquina.idAluno = idAluno;

                    MaquinaBRL maquinaBRL = new MaquinaBRL();
                    DataTable dtMaquina = maquinaBRL.searchMaquinaByIdAluno(dtoMaquina);

                    for (int i = 0; i < dtMaquina.Rows.Count; i++)
                    {
                        Session.Add("NRSerie"+i, dtMaquina.Rows[i]["NrSerieMaquina"].ToString());
                    }

                    if (dtMaquina.Rows.Count == 0)
                    {
                        Session.Add("NRSerie0", "");
                        Session.Add("NRSerie1", "");
                        Session.Add("NRSerie2", "");
                    }
                }
            }
        }

        protected void cmdImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

                AlunoDTO dto = new AlunoDTO();
                dto.idAluno = int.Parse(Session["I"].ToString());
                dto.aceiteMaquina = "S";

                AlunoBRL brl = new AlunoBRL();
                brl.updateAlunoAceiteMaquina(dto);
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