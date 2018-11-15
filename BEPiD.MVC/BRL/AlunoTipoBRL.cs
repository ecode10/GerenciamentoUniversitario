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
    public class AlunoTipoBRL
    {
        private AlunoTipoDAO _alunoTipoDAO;

        public AlunoTipoBRL()
        {
            if (_alunoTipoDAO == null)
                _alunoTipoDAO = new AlunoTipoDAO();
        }

        public DataTable searchByIdTipoAluno(AlunoTipoDTO dto)
        {
            try
            {
                return _alunoTipoDAO.searchByIdTipoAluno(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchAllTipo()
        {
            try
            {
                return _alunoTipoDAO.searchAllTipo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
