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
    internal class ProfessorDAO : Context
    {
        internal void insertMaquina(ProfessorDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"INSERT INTO Professor (nomeProfessor, emailProfessor, PWProfessor)
                        VALUES (@nomeProfessor, @emailProfessor, @PWProfessor)");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter titulo = new SqlParameter();
            titulo.ParameterName = "@nomeProfessor";
            titulo.Value = dto.nomeProfessor;
            titulo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(titulo);

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@emailProfessor";
            data.Value = dto.emailProfessor;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter descricao = new SqlParameter();
            descricao.ParameterName = "@PWProfessor";
            descricao.Value = dto.pwProfessor;
            descricao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(descricao);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateProfessorSenhaByEmaileId(ProfessorDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Professor set PWProfessor = @password WHERE EmailProfessor=@Email and IdProfessor=@Id");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@Id";
            data.Value = dto.idProfessor;
            data.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@Email";
            email.Value = dto.emailProfessor;
            email.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@password";
            situac.Value = dto.pwProfessor;
            situac.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal DataTable allProfessor()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT idProfessor, NomeProfessor, EmailProfessor FROM Professor
                            ORDER BY NomeProfessor");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchProfessor(ProfessorDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT idProfessor, NomeProfessor, EmailProfessor FROM Professor
                            WHERE EmailProfessor = @Email AND PWProfessor = @pw");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@Email";
            situacao.Value = dto.emailProfessor;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            IDataParameter senha = new SqlParameter();
            senha.ParameterName = "@pw";
            senha.Value = dto.pwProfessor;
            senha.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(senha);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchProfessorByEmail(ProfessorDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT idProfessor, NomeProfessor, EmailProfessor, PWProfessor FROM Professor
                            WHERE EmailProfessor = @Email ");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@Email";
            situacao.Value = dto.emailProfessor;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }
    }
}
