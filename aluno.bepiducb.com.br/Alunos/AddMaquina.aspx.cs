using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aluno.bepiducb.com.br.Alunos
{
    public partial class AddMaquina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (Session["SAluno"] == null)
                Response.Redirect("../Login");

            if (Session["SAluno"].Equals("P"))
                Response.Redirect("../Login.aspx");

            if (!Page.IsPostBack)
            {
                preencherCombo();
                preencherGrid();

                if (Request.Params["Situacao"] != null)
                {
                    if (Request.Params["Situacao"].Equals("1"))
                    {
                        lblResultado.Text = "Dados inseridos com sucesso.";
                        limpaCampos();
                    }
                }

                if (Request.Params["id"] != null)
                {
                    if (Request.Params["id"].Equals("Deletado"))
                    {
                        lblResultado.Text = "Dados deletados com sucesso.";
                        limpaCampos();
                    }
                }
            }
        }

        private void limpaCampos()
        {
            txtModelo.Text = "";
            txtNrSerie.Text = "";
            cmbTipo.SelectedIndex = -1;
            txtIMEI.Text = "";
        }

        private void preencherGrid()
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            if (Session["IAluno"]!= null) //0 é para os administradores
            {
                MaquinaDTO dto = new MaquinaDTO();
                dto.idAluno = int.Parse(Session["IAluno"].ToString());

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
                    dto.idAluno = int.Parse(Session["IAluno"].ToString());

                    MaquinaBRL brl = new MaquinaBRL();
                    if (brl.insertMaquina(dto))
                    {
                        Response.Redirect("AddMaquina?Situacao=1");
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
            Response.Redirect("/Alunos/AddMaquina");
        }

        protected void grdMaquinas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Deletar")
            {
                int _index = int.Parse((string)e.CommandArgument);
                string chave = grdMaquinas.DataKeys[_index]["IdMaquina"].ToString();

                MaquinaDTO dto = new MaquinaDTO();
                dto.idMaquina = int.Parse(chave);

                MaquinaBRL brl = new MaquinaBRL();
                if (brl.deleteMaquina(dto))
                    Response.Redirect("AddMaquina.aspx?id=deletado");
            }
        }
    }
}