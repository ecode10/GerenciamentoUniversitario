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
    public class ProfessorBRL
    {
        private ProfessorDAO _professorDAO;
        public ProfessorBRL()
        {
            if (_professorDAO == null)
                _professorDAO = new ProfessorDAO();
        }

        public DataTable allProfessor()
        {
            try
            {
                return _professorDAO.allProfessor();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean updateProfessorSenhaByEmaileId(ProfessorDTO dto)
        {
            try
            {
                _professorDAO.updateProfessorSenhaByEmaileId(dto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean insertMaquina(ProfessorDTO dto)
        {
            try
            {
                _professorDAO.insertMaquina(dto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchProfessor(ProfessorDTO dto)
        {
            try
            {
                return _professorDAO.searchProfessor(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchProfessorByEmail(ProfessorDTO dto)
        {
            try
            {
                return _professorDAO.searchProfessorByEmail(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
