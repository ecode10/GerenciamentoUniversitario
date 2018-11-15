using BEPiD.Business.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.DAO
{
    internal class CategoriaDAO : Context
    {
        internal DataTable searchCategoria(CategoriaDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@" SELECT IdCategoria, NomeCategoria FROM Categoria WHERE 1=1 ");

            if(dto.idCategoria!=0)
                str.Append(@" AND IdCategoria = @IdCategoria ");

            if(!String.IsNullOrEmpty(dto.nomeCategoria))
                str.Append(@" AND NomeCategoria = @nomeCategoria ");

            str.Append(@" Order by NomeCategoria ");


            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            if (!String.IsNullOrEmpty(dto.nomeCategoria))
            {
                IDataParameter nome = new SqlParameter();
                nome.ParameterName = "@nomeCategoria";
                nome.Value = "%" + dto.nomeCategoria + "%";
                nome.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(nome);
            }

            if (dto.idCategoria != 0)
            {
                IDataParameter situacao = new SqlParameter();
                situacao.ParameterName = "@IdCategoria";
                situacao.Value = dto.idCategoria;
                situacao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(situacao);
            }

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }
    }
}
