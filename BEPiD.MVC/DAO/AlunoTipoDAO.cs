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
    internal class AlunoTipoDAO : Context
    {

        internal DataTable searchAllTipo()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT IdTipoAluno, DescricaoTipoAluno FROM AlunoTipo order by DescricaoTipoAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchByIdTipoAluno(AlunoTipoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT IdTipoAluno, DescricaoTipoAluno FROM AlunoTipo WHERE IdTipoAluno = @idTipo order by DescricaoTipoAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@idTipo";
            situacao.Value = dto.idTipoAluno;
            situacao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

    }
}
