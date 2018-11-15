using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD2017
{
    public partial class AppsPublicados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                preencherGrid(0, "");
                preencherGridCategoria();
            }
        }

        private void preencherGrid(int idCategoria, string nomeAplicativo)
        {
            AplicativoDTO dto = new AplicativoDTO();

            if (!String.IsNullOrEmpty(cmbCategorias.SelectedValue))
                dto.idCategoria = int.Parse(cmbCategorias.SelectedValue.ToString());

            if (!String.IsNullOrEmpty(nomeAplicativo))
                dto.nomeAplicativo = nomeAplicativo;

            AplicativoBRL brl = new AplicativoBRL();
            DataTable dt = brl.searchAplicativo(dto);

            //grid só o ícone   
            this.gridAppsList.DataSource = dt;
            this.gridAppsList.DataBind();

            //grid com detalhes
            //this.gridAplicativos.DataSource = dt;
            //this.gridAplicativos.DataBind();

            lblQuantidadeApps.Text = dt.Rows.Count.ToString() + " publicados.";
        }


        private void preencherGridCategoria()
        {
            CategoriaDTO dto = new CategoriaDTO();

            CategoriaBRL _categoriaBRL = new CategoriaBRL();
            this.cmbCategorias.DataSource = _categoriaBRL.searchCategoria(dto);

            this.cmbCategorias.DataTextField = "NomeCategoria";
            this.cmbCategorias.DataValueField = "IdCategoria";
            this.cmbCategorias.DataBind();

            this.cmbCategorias.Items.Insert(0, new ListItem("Todos", ""));
            //this.cmbCategoria.Attributes.Add("0", "Selecione");
        }

        protected void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbCategorias.SelectedValue.ToString()))
                preencherGrid(int.Parse(cmbCategorias.SelectedValue.ToString()),"");
            else
                preencherGrid(0, "");
        }

        protected void cmdBuscar_Click(object sender, EventArgs e)
        {
            preencherGrid(0, txtNome.Text);
        }
    }
}