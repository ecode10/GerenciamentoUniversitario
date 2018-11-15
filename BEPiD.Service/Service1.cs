using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Bancoob.Data;
using System.Threading;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Timers;

namespace BEPiD.Service
{
    public partial class Service1 : ServiceBase
    {
        private Thread threadInicial;
        private bool iniciandoServico = true;
        System.Timers.Timer tempoExecucao;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            iniciandoServico = true;
            threadInicial = new Thread(new ThreadStart(this.iniciar));
            threadInicial.Name = "Iniciar Serviço Agendado ";
            threadInicial.IsBackground = true;
            threadInicial.Start();

        }

        public void iniciar()
        {
            this.tempoExecucao = new System.Timers.Timer(23);
            this.tempoExecucao.Elapsed += new ElapsedEventHandler(this.tempoExecucao_tick);
            this.tempoExecucao.Start();
        }

        private void tempoExecucao_tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            mandarEmail();
        }

        private void mandarEmail()
        {
            DataTable dt = new DataTable();
            int i=0;
            var mensagem = @"Prezado ex-estudante do BEPiD:
<Br><Br>
Como vocês sabem, ao longo destes quatro anos de existência do BEPiD, passamos por várias mudanças. No momento, estamos realizando uma pesquisa para saber o que aconteceu com os nossos estudantes após a conclusão da capacitação realizada no BEPiD. Para alcançar o nosso objetivo, solicitamos a sua colaboração no preenchimento do questionário apontado no link abaixo, , se possível até o dia 05/12, cujo preenchimento leva em torno de 15 minutos:
<Br><Br>
 <a href='https://bepiducb.typeform.com/to/UGMh0j'>https://bepiducb.typeform.com/to/UGMh0j</a>
<Br><Br>
 Neste ano tivemos ainda uma mudança no nome do  nosso projeto de BEPiD para Apple Developer Academy. No formulário a ser preenchido, colocamos uma questão onde gostaríamos de saber do seu interesse em trocar o seu certificado de participação, para os estudantes que os receberam, para o novo nome do projeto. Para os alunos que ainda não receberam o certificado de participação, o certificado será emitido com o nome Apple Developer Academy.
<Br><Br>
Agradecemos a sua participação pois ela é fundamental para que possamos melhorar o projeto para as próximas turmas e ainda conhecer as contribuições da capacitação para a sua carreira profissional.
<BR><Br><Br>
 

Atenciosamente
<Br><Br>
Coordenação do Apple Developer Academy da Universidade Católica de Brasília.";

            try
            {
                this.tempoExecucao.Stop();
                //BEPiD.Business.DTO.AlunoDTO dto = new Business.DTO.AlunoDTO();
                //dto.situacao = "P";
                //dto.ano = 2017;

                BEPiD.Business.BRL.AlunoBRL brl = new Business.BRL.AlunoBRL();
                //dt = brl.searchAlunoInscricao(dto);
                dt = brl.searchAlunoByAno2014E2015();

                //envia e-mail os primeiros 200

                //var sql3 = "select top 200 * from aluno where ano = @ano and situacao= @situacao and IdTipoAluno = @IdTipoAluno and idaluno > @IdAluno order by IdAluno";
                //dt = brl.buscaAlunosParaEnvioDeEmail(dto, sql3, 51759);

                //busca os dados dos alunos
                i = FazendoFor(dt, i, mensagem);
                

            }
            catch (Exception ex)
            {
                //envioDefinitivo(dt, i++);
                i = FazendoFor(dt, i, mensagem);
            }
            finally
            {
                this.tempoExecucao.Start();
            }
        }

        private static int FazendoFor(DataTable dt, int i, string mensagem)
        {
            for (i = 0; i < dt.Rows.Count; i++)
            {
                envioDefinitivo(dt, i, mensagem);
            }
            return i;
        }

        private static void envioDefinitivo(DataTable dt, int i, string mensagem)
        {
            System.Threading.Thread.Sleep(2000);
            //BEPiD.Business.Util.EmailEnvio.SendSimpleMessage(dt.Rows[i]["nome"].ToString(), dt.Rows[i]["email"].ToString());
            //System.Threading.Thread.Sleep(3000);

            //StringBuilder str = new StringBuilder();
            //str.Append("");

            BEPiD.Business.Util.EmailEnvio.SendSimpleMessage(dt.Rows[i]["nome"].ToString(),
                dt.Rows[i]["email"].ToString(), mensagem, "BEPiD UCB - Para ex-alunos");
        }


        protected override void OnStop()
        {
        }
    }
}
