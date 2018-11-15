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
    public partial class Maquinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
           

            if (!Page.IsPostBack)
            {
                preencherCombo();
                preencherGrid();
                preencherDadosUsuario();

                if (Request.Params["Situacao"] != null)
                {
                    if (Request.Params["Situacao"].Equals("1"))
                        lblResultado.Text = "Dados inseridos com sucesso.";
                }
            }
        }

        private void preencherDadosUsuario()
        {
            if (Request.Params["Id"] != null)
            {
                AlunoDTO dto = new AlunoDTO();
                dto.idAluno = int.Parse(Request.Params["id"].ToString());

                AlunoBRL brl = new AlunoBRL();
                DataTable dt = brl.searchDadosPrincipais(dto);

                if (dt != null && dt.Rows.Count > 0)
                {
                    lblNumeroAluno.Text = "Número do Kit: " + dt.Rows[0]["Numero"].ToString();
                    lblNomeAluno.Text = dt.Rows[0]["Nome"].ToString();
                    lblEmailAluno.Text = dt.Rows[0]["Email"].ToString();
                    lblImagem.Text = "<img src='http://s3.amazonaws.com/BEPiD/" + dt.Rows[0]["Foto"].ToString() + "' style='border-radius:20px; width:200px;'/>";
                }
                else
                {
                    lblNumeroAluno.Text = "Não consegui achar o aluno.";
                }
            }

        }

        private void preencherGrid()
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            //if (Session != null && !Session["I"].Equals("0")) //0 é para os administradores
            if(Request.Params["Id"]!=null)
            {
                MaquinaDTO dto = new MaquinaDTO();
                dto.idAluno = int.Parse(Request.Params["Id"].ToString());

                MaquinaBRL brl = new MaquinaBRL();
                grdMaquinas.DataSource = brl.searchMaquinaByIdAluno(dto);
                grdMaquinas.DataBind();
            }
        }

        private void preencherCombo()
        {
            TipoMaquinaBRL brl = new TipoMaquinaBRL();
            cmbTipo.DataSource = brl.showTipoMaquina();
            cmbTipo.DataTextField = "descricaoTipo";
            cmbTipo.DataValueField = "idTipo";

            cmbTipo.DataBind();

            cmbTipo.Items.Insert(0, new ListItem("Selecione", ""));
        }

        protected void cmdGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    MaquinaDTO dto = new MaquinaDTO();
                    dto.modeloMaquina = txtModelo.Text;
                    dto.nrSerieMaquina = txtNrSerie.Text;
                    dto.idTipo = int.Parse(cmbTipo.SelectedValue);
                    dto.imei = txtIMEI.Text;
                    
                    //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
                    //if (Session != null && !Session["I"].Equals("0")) //0 é para os administradores
                    if(Request.Params["Id"]!=null)
                        dto.idAluno = int.Parse(Request.Params["Id"].ToString());

                    MaquinaBRL brl = new MaquinaBRL();
                    if (brl.insertMaquina(dto))
                    {
                        Response.Redirect("Maquinas?Situacao=1&Id=" + Request.Params["Id"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Um erro aconteceu - " + ex.Message.ToString() + ex.StackTrace.ToString();
            }
        }

        protected void cmdLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Private/Maquinas?Id=" + Request.Params["Id"].ToString());
        }
    }
}