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
    public partial class Contrato_Aditivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

                //if (Session == null || Session["I"].ToString().Equals("0"))
                //{
                //    Response.Redirect("Login");
                //}
                if(Session["N"]!=null)
                {
                    int idAluno = int.Parse(Request.Params["id"].ToString());

                    //buscando dados do aluno
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
                        Session.Add("N", dtAluno.Rows[0]["Nome"].ToString());
                        Session.Add("CPF", dtAluno.Rows[0]["CPF"].ToString());
                    }


                    //buscando dados da máquina
                    MaquinaDTO maquinaDTO = new MaquinaDTO();
                    maquinaDTO.idAluno = idAluno;

                    BEPiD.Business.BRL.MaquinaBRL maquinaBRL = new Business.BRL.MaquinaBRL();
                    DataTable dtMaquina = maquinaBRL.searchMaquinaByIdAluno(maquinaDTO);

                    //if (dtMaquina != null && dtMaquina.Rows.Count > 0)
                    for (int i = 0; i < dtMaquina.Rows.Count; i++)
                    {
                        if (dtMaquina.Rows[i]["idTipo"].ToString().Equals("1"))
                            Session.Add("Macbook", dtMaquina.Rows[i]["NrSerieMaquina"].ToString());

                        if (dtMaquina.Rows[i]["idTipo"].ToString().Equals("2"))
                            Session.Add("iPad", dtMaquina.Rows[i]["NrSerieMaquina"].ToString());

                        if (dtMaquina.Rows[i]["idTipo"].ToString().Equals("3"))
                            Session.Add("iPhone", dtMaquina.Rows[i]["NrSerieMaquina"].ToString());
                    }

                    geraWord(sender, e);

                }
            }
        }

        protected void geraWord(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];

            

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/msword";
            Response.AddHeader("content-disposition", "attachment;filename=" + Session["N"].ToString() + ".doc");
            Response.Charset = "";
            this.EnableViewState = false;
            System.IO.StringWriter os = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oh = new HtmlTextWriter(os);
            Response.Write(os);

           
        }
    }
}