using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.DTO
{
    public class MaquinaDTO
    {
        public int idMaquina { get; set; }

        public string modeloMaquina { get; set; }

        public string nrSerieMaquina { get; set; }

        public int idTipo { get; set; }

        public int idAluno { get; set; }

        public string imei { get; set; }
    }
}
