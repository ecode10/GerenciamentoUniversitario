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
    public class CategoriaBRL
    {
        CategoriaDAO _categoriaDAO;

        public CategoriaBRL()
        {
            if (_categoriaDAO == null)
                _categoriaDAO = new CategoriaDAO();
        }

        public DataTable searchCategoria(CategoriaDTO dto)
        {
            try
            {
                return _categoriaDAO.searchCategoria(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
