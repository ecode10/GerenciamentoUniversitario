using BEPiD.Business.DAO;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.BRL
{
    public class TipoMaquinaBRL
    {
        private TipoMaquinaDAO _tipoMaquinaDAO;

        public TipoMaquinaBRL()
        {
            if (_tipoMaquinaDAO == null)
                _tipoMaquinaDAO = new TipoMaquinaDAO();
        }


        public DataTable showTipoMaquina()
        {
            try
            {
                return _tipoMaquinaDAO.showTipoMaquina();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
