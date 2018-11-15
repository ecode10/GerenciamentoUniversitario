using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEPiD.Business.DTO;
using System.Data.SqlClient;

namespace BEPiD.Business.DAO
{
    internal class TipoMaquinaDAO : Context
    {
        internal DataTable showTipoMaquina()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT idTipo, descricaoTipo from TipoMaquina order by descricaoTipo ");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }
    }
}
