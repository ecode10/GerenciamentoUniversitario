using BEPiD.Business.DAO;
using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BEPiD.Business.BRL
{
    public class AplicativoBRL
    {
        AplicativoDAO _aplicativoDAO;

        public AplicativoBRL()
        {
            if (_aplicativoDAO == null)
                _aplicativoDAO = new AplicativoDAO();
        }

        public DataTable searchAplicativoByCategoria()
        {
            try
            {
                return _aplicativoDAO.searchAplicativoByCategoria();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean deleteAplicativo(AplicativoDTO dto)
        {
            try
            {
                _aplicativoDAO.deleteAplicativo(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: "  + ex.Message.ToString()  + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAplicativoTop()
        {
            try
            {
                return _aplicativoDAO.searchAplicativoTop();
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }
        public Boolean insertAplicativo(AplicativoDTO dto)
        {
            try
            {
                _aplicativoDAO.insertAplicativo(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAplicativo(AplicativoDTO dto)
        {
            try
            {
                return _aplicativoDAO.searchAplicativo(dto);
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }
    }
}
