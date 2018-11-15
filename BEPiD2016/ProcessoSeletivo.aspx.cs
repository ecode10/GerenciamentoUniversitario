using BEPiD.Business.BRL;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD2016
{
    public partial class ProcessoSeletivo : System.Web.UI.Page
    {
        //constantes
        protected const int _dia = 21;
        protected const int _mes = 11;
        protected const int _ano = 2016;

        protected void Page_Load(object sender, EventArgs e)
        {
            //verifica a hora e data para encerrar as inscricoes.
            //if (DateTime.Now.Day >= 21 && DateTime.Now.Month >= 11 && DateTime.Now.Year >= 2016)
            //Response.Redirect("InscricoesEncerradas");

            //verifica se as inscricoes foram encerradas
            //if (BEPiD.Business.Util.Validacao.isInscricaoEncerrada(_dia, _mes, _ano))
                Response.Redirect("InscricoesEncerradas");

            if (Request.Params["Situacao"] != null)
            {
                if (Request.Params["Situacao"].Equals("1"))
                {
                    lblResultado.Text = @"<Br><Br>Sua inscrição foi realizada com sucesso. Leia o edital e fique atento com as datas e resultados.<br><br>";
                    lblResultado.Visible = true;
                    this.tbCadastro.Visible = false;
                    this.cmdVoltar.Visible = true;
                    this.cmdEnviar.Visible = false;
                }
            }

            if (!Page.IsPostBack)
            {
                txtNome.Focus();
            }
        }

        public DateTime formataDataYYYYMMDD(String data)
        {
            String dataTotal = data;

            String dia = dataTotal.Substring(0, 2);
            if (dia.Length == 1)
                dia = "0" + dia;
            String mes = dataTotal.Substring(3, 2);
            if (mes.Length == 1)
                mes = "0" + mes;
            String ano = dataTotal.Substring(6, 4);


            return Convert.ToDateTime(mes + "-" + dia + "-" + ano);
        }

        public String formataMMYYYY(String data)
        {
            String dataTotal = data;

            String dia = dataTotal.Substring(0, 2);
            if (dia.Length == 1)
                dia = "0" + dia;
            String mes = dataTotal.Substring(3, 2);
            if (mes.Length == 1)
                mes = "0" + mes;
            String ano = dataTotal.Substring(6, 4);

            return mes + "-" + ano;
        }

        private void enviadEmailAluno(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            var sexo = "";
            if(dto.sexo.Equals("F"))
                sexo = "Prezada aluna " + dto.nome;
            else
                sexo = "Prezado aluno " + dto.nome;
            str.Append(@"<img src='http://www.bepiducb.com.br/img/Untitled-2.png' width='180'/><Br><br>" + sexo + "");
            str.Append(@"
                    <br><Br>Bem vindo(a) ao processo seletivo BEPiD UCB - www.bepiducb.com.br. <br>
                    É muito importante ler o edital e prestar atenção nas datas listadas no site. <br>
                    Boa sorte e qualquer dúvida, favor entrar em contato conosco.");

            string[] _emails = new string[1];
            _emails[0] = dto.email;

            BEPiD.Business.Util.EmailEnvio.enviaEmail(_emails, "E-mail automático de cadastro bepiducb.com.br", str.ToString());
        }


        private void enviadEmailAdministradores(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();

            str.Append(@"<img src='http://www.bepiducb.com.br/img/Untitled-2.png' width='180'/><Br><br> O(a) aluno(a) " + txtNome.Text + ", instituição: " + cmbInstituicao.SelectedValue.ToString() + ", CPF: " + txtCPF.Text + ", e-mail: " + txtEmail.Text +
                " acaba de se cadastrar no sistema BEPiD UCB para o processo seletivo " + dto.ano);

            AlunoBRL brl = new AlunoBRL();
            String total = brl.searchTotalAlunoInscricao(dto);

            str.Append(@"<br><br><b> Temos o total de: " + total + " aluno(s) cadastrado(s).</b>");

            string[] _emails = new string[4];
            //_emails[0] = "braga@ucb.br";
            //_emails[1] = "hartmann@ucb.br";
            _emails[0] = "jairab@yahoo.com.br";
            _emails[1] = "moresi@ucb.br";
            _emails[2] = "mauricio.analista@yahoo.com";
            _emails[3] = "bepiducb@gmail.com";

            BEPiD.Business.Util.EmailEnvio.enviaEmail(_emails, "E-mail automático de cadastro bepiducb.com.br", str.ToString());
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            AlunoDTO dto = null;
            try
            {
                if (Page.IsValid)
                {
                    //verifica se as inscricoes foram encerradas
                    if (BEPiD.Business.Util.Validacao.isInscricaoEncerrada(_dia, _mes, _ano))
                        Response.Redirect("InscricoesEncerradas");

                    if (BEPiD.Business.Util.Validacao.IsValidCPF(txtCPF.Text))
                    {
                        dto = new AlunoDTO();
                        dto.celular = txtCelular.Text;
                        dto.cidade = txtCidade.Text;
                        dto.cpf = txtCPF.Text.Replace(".","").Replace("-","");
                        dto.dataNascimento = Convert.ToDateTime(txtDataNascimento.Text.Replace("/","-"));
                        dto.email = txtEmail.Text;
                        dto.endereco = txtEndereco.Text;
                        dto.estado = cmbEstado.SelectedValue.ToString();
                        dto.identidade = txtIdentidade.Text;
                        dto.nome = txtNome.Text;
                        dto.nomeUniversidade = cmbInstituicao.SelectedValue.ToString();
                        dto.orgao = txtOrgao.Text;
                        dto.telefone = txtTelefone.Text;
                        dto.cep = txtCEP.Text;
                        dto.estadoCivil = cmbEstadoCivil.SelectedValue.ToString();
                        dto.nacionalidade = cmbNacionalidade.SelectedValue.ToString();
                        dto.ano = 2017;
                        dto.sexo = cmbSexo.SelectedValue.ToString();
                        dto.dataDeExpedicao = Convert.ToDateTime(txtDataExpedicaoRG.Text.Replace("/","-"));
                        dto.nomeDaMae = txtNomedaMae.Text;
                        dto.inglesLeitura = rdLeitura.SelectedValue.ToString();
                        dto.inglesEscrita = rdEscrita.SelectedValue.ToString();
                        dto.inglesComunicacaoVerbal = rdComunicacaoVerbal.SelectedValue.ToString();
                        dto.curso = txtCurso.Text;
                        dto.semestre = cmbSemestre.SelectedValue.ToString();
                        dto.previsaoFormatura = formataMMYYYY(txtPrevisaoFormatura.Text);
                        dto.ocupacaoAtual = cmbOcupacaoAtual.SelectedValue.ToString();
                        dto.situacao = "P";
                        dto.naturalidade = txtNatural.Text;

                        if (!String.IsNullOrEmpty(this.rdTipoAluno.SelectedValue))
                            dto.idTipoAluno = int.Parse(rdTipoAluno.SelectedValue.ToString());
                        else
                        {
                            lblResultado.Text = "<Br>Atenção: escolha o tipo de vaga.";
                            lblResultado.Visible = true;
                        }

                        //verifica se é designer ou developer
                        if (this.rdTipoAluno.SelectedValue.Equals("1") && String.IsNullOrEmpty(txtLinkPortifolio.Text))
                        {
                            lblResultado.Text = "<br>Atenção: Se você está se inscrevendo para designer, é necessário colocar um link de portifólio";
                            lblResultado.Visible = true;
                        }
                        else
                        {
                            dto.linkPortifolio = txtLinkPortifolio.Text;
                        }

                        AlunoBRL _brl = new AlunoBRL();

                        //verifica se já existe o cpf e e-mail
                        if (_brl.verifyCPFAndEmail(dto))
                        {
                            lblResultado.Text = "<br>Atenção: já existe esse CPF/E-mail cadastrado no nosso banco de dados.";
                            lblResultado.Visible = true;
                        }
                        else
                        {
                            if (_brl.insertAlunoInscricao(dto))
                            {
                                //enviando e-mail de cadastro
                                enviadEmailAdministradores(dto);

                                //enviado e-mail para o usuário
                                enviadEmailAluno(dto);

                                //System.Threading.Thread.Sleep(2);
                               Response.Redirect("ProcessoSeletivoSucesso.aspx", false);
                            }
                        }
                    }
                    else
                    {
                        lblResultado.Text = "<br>Digite um CPF válido.";
                        lblResultado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "<br>Ops! Um erro aconteceu! - estamos tentando resolver o mais rápido possível.";
                lblResultado.Visible = true;

                //envia email de erro.
                enviarEmailParaAdministradordoSite(dto, ex);
            }
        }

        private void enviarEmailParaAdministradordoSite(AlunoDTO dto, Exception ex)
        {
            StringBuilder str = new StringBuilder();

            str.Append(@"<img src='http://www.bepiducb.com.br/img/Untitled-2.png' width='180'/><Br><br> O(a) aluno(a) " + txtNome.Text + ", instituição: " + cmbInstituicao.SelectedValue.ToString() + ", CPF: " + txtCPF.Text + ", e-mail: " + txtEmail.Text +
                " acaba de se cadastrar no sistema BEPiD UCB para o processo seletivo " + dto.ano);

            str.Append(@"<br><br>Mas ocorreu um erro no momento de cadastrar: " + ex.InnerException + ex.Source + ex.Message + ex.ToString());

            string[] _emails = new string[1];
            _emails[0] = "mauricio.analista@yahoo.com";

            BEPiD.Business.Util.EmailEnvio.enviaEmail(_emails, "Erro automático de cadastro bepiducb.com.br", str.ToString());
        }

        protected void cmdVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.html");
        }

        protected void rdTipoAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdTipoAluno.SelectedValue.ToString().Equals("1"))
            {
                //aparece o campo
                tbDesigner.Visible=true;
            }
            else
            {
                //esconde o campo
                tbDesigner.Visible = false;
            }
        }
    }
}