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
    public partial class AllVinculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
          

            //retirando o botao de limpar
            cmdLimpar.Visible = false;

            if (!Page.IsPostBack)
            {
                preencherCombo();

                if (Request.Params["Situacao"] != null)
                {
                    if (Request.Params["Situacao"].Equals("1"))
                        lblResultado.Text = "Dados inseridos com sucesso.";
                }
                else if (Request.Params["id"] != null)
                {
                    hdIdAluno.Value = Request.Params["id"].ToString();
                    preencherDados();
                    preencherDadosUsuario();
                }
            }
        }

        private void preencherDadosUsuario()
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
                lblImagem.Text = "<img src='http://s3.amazonaws.com/BEPiD/"+dt.Rows[0]["Foto"].ToString()+"' style='border-radius:20px; width:200px;'/>";
            }
            else
            {
                lblNumeroAluno.Text = "Não consegui achar o aluno.";
            }

        }

        private void preencherDados()
        {
            try
            {
                MaquinaDTO _dto = new MaquinaDTO();
                _dto.idAluno = int.Parse(hdIdAluno.Value);

                MaquinaBRL _maquinaBRL = new MaquinaBRL();
                DataTable dtMaquina = _maquinaBRL.searchMaquinaByIdAluno(_dto);

                if (dtMaquina != null && dtMaquina.Rows.Count > 0)
                {
                    cmbTipo.SelectedValue = dtMaquina.Rows[0]["IdTipo"].ToString();
                    txtNrSerie.Text = dtMaquina.Rows[0]["NrSerieMaquina"].ToString();
                    txtModelo.Text = dtMaquina.Rows[0]["ModeloMaquina"].ToString();
                    hdIdMaquina.Value = dtMaquina.Rows[0]["IdMaquina"].ToString();
                    hdIdAluno.Value = dtMaquina.Rows[0]["IdAluno"].ToString();
                    cmdGravar.Visible = false;
                }
                else
                {
                    cmdAtualizar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
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

        protected void cmdLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Private/AllUser");
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
                    //if (Session != null && !Session["I"].Equals("0")) //0 é para os administradores
                    
                    dto.idAluno = int.Parse(hdIdAluno.Value);

                    MaquinaBRL brl = new MaquinaBRL();
                    if (brl.insertMaquina(dto))
                    {
                        //Response.Redirect("AllVinculo?Situacao=1");
                        lblResultado.Text = "Inserido com sucesso.";
                    }

                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Um erro aconteceu - " + ex.Message.ToString() + ex.StackTrace.ToString();
            }
        }

        protected void cmdAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MaquinaDTO _dto = new MaquinaDTO();
                _dto.idAluno = int.Parse(hdIdAluno.Value);
                _dto.idMaquina = int.Parse(hdIdMaquina.Value);
                _dto.modeloMaquina = txtModelo.Text;
                _dto.nrSerieMaquina = txtNrSerie.Text;
                _dto.idTipo = int.Parse(cmbTipo.SelectedValue);

                MaquinaBRL _brl = new MaquinaBRL();
                if (_brl.updateMaquina(_dto))
                {
                    lblResultado.Text = "Atualizado com sucesso.";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaquinaDTO maquinaDTO = new MaquinaDTO();
            maquinaDTO.idTipo = int.Parse(cmbTipo.SelectedValue.ToString());
            maquinaDTO.idAluno = int.Parse(hdIdAluno.Value);

            MaquinaBRL _brl = new MaquinaBRL();
            DataTable dt = _brl.searchMaquinaByIdTipoAndIdAluno(maquinaDTO);

            if (dt != null && dt.Rows.Count > 0)
            {
                txtNrSerie.Text = dt.Rows[0]["NrSerieMaquina"].ToString();
                txtModelo.Text = dt.Rows[0]["ModeloMaquina"].ToString();
                hdIdMaquina.Value = dt.Rows[0]["IdMaquina"].ToString();
                hdIdAluno.Value = dt.Rows[0]["IdAluno"].ToString();
            }
            else
            {
                txtNrSerie.Text = "";
                txtModelo.Text = "";
                cmdAtualizar.Visible = false;
                cmdGravar.Visible = true;
            }
        }
    }
}