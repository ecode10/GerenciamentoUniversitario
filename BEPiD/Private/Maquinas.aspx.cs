using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD.Private
{
    public partial class Maquinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (!Session["S"].Equals("P"))
                Response.Redirect("Login.aspx");

            if (!Page.IsPostBack)
            {
                preencherCombo();
                preencherGrid();

                if (Request.Params["Situacao"] != null)
                {
                    if (Request.Params["Situacao"].Equals("1"))
                        lblResultado.Text = "Dados inseridos com sucesso.";
                }
            }
        }

        private void preencherGrid()
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (Session != null && !Session["I"].Equals("0")) //0 é para os administradores
            {
                MaquinaDTO dto = new MaquinaDTO();
                dto.idAluno = int.Parse(Session["I"].ToString());

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
                    
                    //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
                    if (Session != null && !Session["I"].Equals("0")) //0 é para os administradores
                        dto.idAluno = int.Parse(Session["I"].ToString());

                    MaquinaBRL brl = new MaquinaBRL();
                    if (brl.insertMaquina(dto))
                    {
                        Response.Redirect("Maquinas?Situacao=1");
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
            Response.Redirect("/Private/Maquinas");
        }
    }
}