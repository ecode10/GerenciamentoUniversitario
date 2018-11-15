using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aluno.bepiducb.com.br.Alunos
{
    public partial class DadosPessoais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["Situacao"] != null)
                {
                    if (Request.Params["Situacao"].Equals("1"))
                    {
                        lblResultado.Text = "Dados alterados com sucesso!";
                        buscarDadosAlunos();
                    }
                }
                else
                {
                    buscarDadosAlunos();
                }

                txtNome.Focus();
            }
        }

        private void buscarDadosAlunos()
        {
            AlunoDTO dto = new AlunoDTO();

            //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
            dto.idAluno = int.Parse(Session["IAluno"].ToString());

            AlunoBRL brl = new AlunoBRL();
            DataTable dt = brl.searchDadosPrincipais(dto);

            if (dt != null && dt.Rows.Count > 0)
            {
                txtNome.Text = dt.Rows[0]["Nome"].ToString();
                txtAgencia.Text = dt.Rows[0]["Agencia"].ToString();
                txtNomeBanco.Text = dt.Rows[0]["BancoNome"].ToString();
                txtNrBanco.Text = dt.Rows[0]["BancoNR"].ToString();
                txtCelular.Text = dt.Rows[0]["Celular"].ToString();
                txtCidade.Text = dt.Rows[0]["Cidade"].ToString();
                txtConta.Text = dt.Rows[0]["Conta"].ToString();
                txtCPF.Text = dt.Rows[0]["CPF"].ToString();
                txtDataNascimento.Text = BEPiD.Business.Util.Data.formataDataRetornoFormulario(dt.Rows[0]["DataNascimento"].ToString());
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtEndereco.Text = dt.Rows[0]["Endereco"].ToString();
                cmbEstado.SelectedValue = dt.Rows[0]["Estado"].ToString();
                txtIdentidade.Text = dt.Rows[0]["Identidade"].ToString();
                txtNome.Text = dt.Rows[0]["Nome"].ToString();
                txtUniversidade.Text = dt.Rows[0]["NomeUniversidade"].ToString();
                txtOrgao.Text = dt.Rows[0]["Orgao"].ToString();
                //txtPassword.Text = "";
                txtTelefone.Text = dt.Rows[0]["Telefone"].ToString();
                txtCEP.Text = dt.Rows[0]["CEP"].ToString();
                cmbEstadoCivil.SelectedValue = dt.Rows[0]["EstadoCivil"].ToString();
                txtNacionalidade.Text = dt.Rows[0]["Nacionalidade"].ToString();
                txtDataExpedicao.Text = BEPiD.Business.Util.Data.formataDataRetornoFormulario(dt.Rows[0]["DataExpedicaoIdentidade"].ToString());
            }

        }
        public String formataDataYYYYMMDD(String data)
        {
            String dataTotal = data;

            String dia = dataTotal.Substring(0, 2);
            String mes = dataTotal.Substring(3, 2);
            String ano = dataTotal.Substring(6, 4);

            return ano + "-" + mes + "-" + dia;
        }

        public String formataDataDDMMYYYY(DateTime data)
        {
            string dia = "";
            string mes = "";
            string ano = "";

            if (data.Day.ToString().Length == 1)
                dia = "0" + data.Day.ToString();

            if (data.Month.ToString().Length == 1)
                mes = "0" + data.Month.ToString();

            ano = data.Year.ToString();
            Response.Write("dia: " + dia);
            Response.Write("mes: " + mes);
            Response.Write("ano: " + ano);

            return dia + "-" + mes + "-" + ano;
        }

        protected void cmdCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = "";
                if (Page.IsValid)
                {
                    if (BEPiD.Business.Util.Validacao.IsValidCPF(txtCPF.Text))
                    {

                        AlunoDTO dto = new AlunoDTO();
                        dto.agencia = txtAgencia.Text;
                        dto.nome = txtNome.Text;
                        dto.bancoNome = txtNomeBanco.Text;
                        dto.bancoNumero = txtNrBanco.Text;
                        dto.celular = txtCelular.Text;
                        dto.cidade = txtCidade.Text;
                        dto.conta = txtConta.Text;
                        dto.cpf = txtCPF.Text;
                        //dto.dataNascimento = Convert.ToDateTime(txtDataNascimento.Text.Replace("/", "-"));
                        dto.email = txtEmail.Text;
                        dto.endereco = txtEndereco.Text;
                        dto.estado = cmbEstado.Text;
                        dto.identidade = txtIdentidade.Text;
                        dto.nome = txtNome.Text;
                        dto.nomeUniversidade = txtUniversidade.Text;
                        dto.orgao = txtOrgao.Text;
                        //dto.password = cript2.code.business.SimpleCripto.Encrypt(txtPassword.Text + txtEmail.Text.Substring(0, 2), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());
                        dto.telefone = txtTelefone.Text;
                        dto.cep = txtCEP.Text;
                        dto.estadoCivil = cmbEstadoCivil.SelectedValue.ToString();
                        dto.nacionalidade = txtNacionalidade.Text;
                        //dto.dataDeExpedicao = Convert.ToDateTime(txtDataExpedicao.Text.Replace("/", "-"));

                        //pegando idaluno
                        //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
                        dto.idAluno = int.Parse(Session["IAluno"].ToString());

                        AlunoBRL _brl = new AlunoBRL();
                        if (_brl.updateAluno(dto))
                        {
                            //enviando e-mail de cadastro
                            //enviadEmailAdministradores();

                            //enviado e-mail para o usuário
                            //enviadEmailAtivacao();

                            Response.Redirect("DadosPessoais?Situacao=1");
                        }
                    }
                    else
                    {
                        lblResultado.Text = "Digite um CPF válido.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Ops! Um erro aconteceu! - " + ex.Message.ToString() + "<Br>" + ex.StackTrace.ToString();
            }

        }
    }
}