using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD
{
    public partial class AppsPublicados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                preencherGrid(0);
                preencherGridCategoria();
            }
        }

        private void preencherGrid(int idCategoria)
        {
            AplicativoDTO dto = new AplicativoDTO();
            
            if (idCategoria != 0)
            {
                dto.idCategoria = idCategoria;
            }

            AplicativoBRL brl = new AplicativoBRL();
            DataTable dt = brl.searchAplicativo(dto);
            this.gridAplicativos.DataSource = dt;
            this.gridAplicativos.DataBind();

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
                preencherGrid(int.Parse(cmbCategorias.SelectedValue.ToString()));
            else
                preencherGrid(0);
        }

    }
}