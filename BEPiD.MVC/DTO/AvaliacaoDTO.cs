using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.DTO
{
    public class AvaliacaoDTO
    {
        public int idAvaliacao { get; set; }

        public DateTime dataAvaliacao { get; set; }

        public int idProfessor { get; set; }

        public string assuntoAvaliacao { get; set; }

        public string tipoAvaliacao { get; set; }

        public string mensagemAvaliacao { get; set; }

        public int idAluno { get; set; }
    }
}
