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
    public class AvaliacaoBRL
    {
        AvaliacaoDAO _avalicacaoDAO;

        public AvaliacaoBRL()
        {
            if (_avalicacaoDAO == null)
                _avalicacaoDAO = new AvaliacaoDAO();
        }

        public DataTable searchCountAvaliacao(AvaliacaoDTO dto)
        {
            try
            {
                return _avalicacaoDAO.searchCountAvaliacao(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchAvaliacaoByIdAluno(AvaliacaoDTO dto)
        {
            try
            {
                return _avalicacaoDAO.searchAvaliacaoByIdAluno(dto);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable searchAvaliacao(AvaliacaoDTO dto)
        {
            try
            {
                return _avalicacaoDAO.searchAvaliacao(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Boolean insertMaquina(AvaliacaoDTO dto)
        {
            try
            {
                _avalicacaoDAO.insertMaquina(dto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
