using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEPiD.Business.DTO;
using BEPiD.Business.DAO;
using System.Data;

namespace BEPiD.Business.BRL
{
    public class MaquinaBRL
    {
        private MaquinaDAO _maquinaDAO;

        public MaquinaBRL()
        {
            if (_maquinaDAO == null)
                _maquinaDAO = new MaquinaDAO();
        }

        public DataTable allMachines()
        {
            try
            {
                return _maquinaDAO.allMachines();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool deleteMaquina(MaquinaDTO dto)
        {
            try
            {
                _maquinaDAO.deleteMaquina(dto);
                return true;
            }
            catch (Exception  ex)
            {
                throw ex;
            }
        }

        public bool insertMaquina(MaquinaDTO dto)
        {
            try
            {
                _maquinaDAO.insertMaquina(dto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchMaquinaByIdTipoAndIdAluno(MaquinaDTO dto)
        {
            try
            {
                return _maquinaDAO.searchMaquinaByIdTipoAndIdAluno(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public DataTable searchMaquinaByIdAluno(MaquinaDTO dto)
        {
            try
            {
                return _maquinaDAO.searchMaquinaByIdAluno(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean updateMaquina(MaquinaDTO dto)
        {
            try
            {
                _maquinaDAO.updateMaquina(dto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
