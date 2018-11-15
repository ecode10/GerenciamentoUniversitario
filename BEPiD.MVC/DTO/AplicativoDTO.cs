using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.DTO
{
    public class AplicativoDTO
    {
        public int idAplicativo { get; set; }

        public int idCategoria { get; set; }

        public string nomeAplicativo { get; set; }

        public string linkAplicativo { get; set; }

        public int idAluno { get; set; }

        public string imagemAplicativo { get; set; }

        public string imagemAplicativo1 { get; set; }

        public string imagemAplicativo2 { get; set; }

        public string imagemAplicativo3 { get; set; }

        public string situacao { get; set; }

        public string nomeGrupoAplicativo { get; set; }

        public string ano { get; set; }

        public string challenge { get; set; }

        public string descricaoAplicativo { get; set; }

        public DateTime dataPublicacaoAplicativo { get; set; }
    }
}
