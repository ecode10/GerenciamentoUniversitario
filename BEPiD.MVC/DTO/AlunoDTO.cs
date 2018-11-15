using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.DTO
{
    public class AlunoDTO
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string nomeUniversidade { get; set; }
        public int idAluno { get; set; }
        public string cpf { get; set; }
        public string identidade { get; set; }
        public string orgao { get; set; }
        public string password { get; set; }
        public string situacao { get; set; }
        public string estadoCivil { get; set; }
        public string cep { get; set; }
        public string nacionalidade { get; set; }
        public string bancoNome { get; set; }
        public string bancoNumero { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }
        public DateTime dataNascimento { get; set; }
        public string aceiteDados { get; set; }
        public string aceiteMaquina { get; set; }
        public string aceiteTermo { get; set; }
        public string linkPortifolio { get; set; }

        public int idProfessor { get; set; }

        public int ano { get; set; }

        public string aceiteContrato { get; set; }

        public string endereco { get; set; }

        public int numero { get; set; }

        public string foto { get; set; }

        public string tipoAvaliacao { get; set; }

        public string sexo { get; set; }

        public DateTime dataDeExpedicao { get; set; }

        public string nomeDaMae { get; set; }

        public string inglesLeitura { get; set; }

        public string inglesEscrita { get; set; }

        public string inglesComunicacaoVerbal { get; set; }

        public string curso { get; set; }

        public string semestre { get; set; }

        public string previsaoFormatura { get; set; }

        public string ocupacaoAtual { get; set; }

        public string naturalidade { get; set; }

        public int idTipoAluno { get; set; }


    }
}
