using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using CriptQuery;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD
{
    public partial class Ativar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null)
                {
                    CriptQuery.SecureQueryString qs = new SecureQueryString(Request["id"]);
                    string _email = qs["email"];

                    AlunoDTO dto = new AlunoDTO();
                    dto.situacao = "A";
                    dto.email = _email;

                    AlunoBRL brl = new AlunoBRL();

                    DataTable dtAluno = brl.searchAlunoByEmail(dto);

                    if (dtAluno != null && dtAluno.Rows.Count > 0)
                    {
                        if (brl.updateAlunoSituacao(dto))
                        {
                            lblResultado.Text = "E-mail " + _email + " do aluno(a) ativado(a) com sucesso.";
                        }
                        else
                        {
                            lblResultado.Text = "Erro ao ativar e-mail. Tente novamente ou entre em contato conosco.";
                        }
                    }
                    else
                    {
                        lblResultado.Text = "Aluno(a) não existente. Entre em contato conosco pelo link Contato";
                    }
                }
            }
        }
    }
}