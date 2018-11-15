using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BEPiD
{
    public partial class Aluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Response.Redirect("ProcessoSeletivo");

                tbCadastro.Visible = false;
                this.Table1.Visible = false;
                lblResultado.Text = "O tempo de cadastro foi encerrado.";

                //if (Request.Params["Situacao"] != null)
                //{
                //    if (Request.Params["Situacao"].Equals("1"))
                //        lblResultado.Text = "Dados inseridos com sucesso!";
                //}

                //txtNome.Focus();
            }
        }

        protected void cmdCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    if (BEPiD.Business.Util.Validacao.IsValidCPF(txtCPF.Text))
                    {

                        AlunoDTO dto = new AlunoDTO();
                        dto.agencia = txtAgencia.Text;
                        dto.bancoNome = txtNomeBanco.Text;
                        dto.bancoNumero = txtNrBanco.Text;
                        dto.celular = txtCelular.Text;
                        dto.cidade = txtCidade.Text;
                        dto.conta = txtConta.Text;
                        dto.cpf = txtCPF.Text;
                        dto.dataNascimento = formataDataYYYYMMDD(txtDataNascimento.Text);
                        dto.email = txtEmail.Text;
                        dto.endereco = txtEndereco.Text;
                        dto.estado = cmbEstado.SelectedValue.ToString();
                        dto.identidade = txtIdentidade.Text;
                        dto.nome = txtNome.Text;
                        dto.nomeUniversidade = txtUniversidade.Text;
                        dto.orgao = txtOrgao.Text;
                        dto.password = cript2.code.business.SimpleCripto.Encrypt(txtPassword.Text + txtEmail.Text.Substring(0, 2), System.Configuration.ConfigurationManager.AppSettings["cript2Hash"].ToString());
                        dto.telefone = txtTelefone.Text;
                        dto.cep = txtCEP.Text;
                        dto.estadoCivil = cmbEstadoCivil.SelectedValue.ToString();
                        dto.nacionalidade = txtNacionalidade.Text;

                        AlunoBRL _brl = new AlunoBRL();
                        if (_brl.insertAluno(dto))
                        {
                            //enviando e-mail de cadastro
                            enviadEmailAdministradores();

                            //enviado e-mail para o usuário
                            enviadEmailAtivacao();

                            Response.Redirect("Aluno?Situacao=1");
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


        public DateTime formataDataYYYYMMDD(String data)
        {
            String dataTotal = data;

            String dia = dataTotal.Substring(0, 2);
            String mes = dataTotal.Substring(3, 2);
            String ano = dataTotal.Substring(6, 4);

            return Convert.ToDateTime(mes + "/" + dia + "/" + ano);
        }

        private void enviadEmailAtivacao()
        {
            StringBuilder str = new StringBuilder();

            str.Append(@" Bem vindo(a) aluno(a) " + txtNome.Text +
                " ao grupo BEPiD UCB. É necessário ativar seu cadastro para pode entrar no sistema. Copie o link abaixo e cole no browser.");

            CriptQuery.SecureQueryString criptografiaURL = new CriptQuery.SecureQueryString();
            criptografiaURL["email"] = txtEmail.Text;

            str.Append(@"<br><Br>Link: http://www.bepiducb.com.br/ativar?id=" + criptografiaURL.ToString());

            string[] _emails = new string[1];
            _emails[0] = txtEmail.Text;

            BEPiD.Business.Util.EmailEnvio.enviaEmail("bepiducb@gmail.com",
                _emails, str.ToString(), "E-mail de confirmação - www.bepiducb.com.br");
        }


        private void enviadEmailAdministradores()
        {
            StringBuilder str = new StringBuilder();

            str.Append(@" O aluno " + txtNome.Text +
                " acaba de se cadastrar no sistema BEPiD UCB. <br>E-mail: " + txtEmail.Text +
                "<br> CPF válido: " + txtCPF.Text);

            string[] _emails = new string[5];
            _emails[0] = "braga@ucb.br";
            _emails[1] = "hartmann@ucb.br";
            _emails[2] = "jairab@yahoo.com.br";
            _emails[3] = "moresi@ucb.br";
            _emails[4] = "mauricio.junior@ucb.br";

            BEPiD.Business.Util.EmailEnvio.enviaEmail("bepiducb@gmail.com",
                _emails, str.ToString(), "E-mail automático de cadastro - www.bepiducb.com.br");
        }

        protected void cmdLimpar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Aluno");
        }
    }
}