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
    internal class MaquinaDAO : Context
    {
        internal void insertMaquina(MaquinaDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"INSERT INTO Maquina (ModeloMaquina, NrSerieMaquina, IdTipo, IdAluno, IMEI) 
                            VALUES (@ModeloMaquina, @NrSerieMaquina, @IdTipo, @IdAluno, @IMEI) ");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter titulo = new SqlParameter();
            titulo.ParameterName = "@ModeloMaquina";
            titulo.Value = dto.modeloMaquina;
            titulo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(titulo);

            IDataParameter ime = new SqlParameter();
            ime.ParameterName = "@IMEI";
            ime.Value = dto.imei;
            ime.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ime);

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@NrSerieMaquina";
            data.Value = dto.nrSerieMaquina;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter descricao = new SqlParameter();
            descricao.ParameterName = "@IdTipo";
            descricao.Value = dto.idTipo;
            descricao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(descricao);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@IdAluno";
            situacao.Value = dto.idAluno;
            situacao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateMaquina(MaquinaDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Maquina SET ModeloMaquina=@ModeloMaquina, NrSerieMaquina=@NrSerieMaquina, IdTipo=@IdTipo, IdAluno=@IdAluno, IMEI=@imei 
                         WHERE IdMaquina = @IdMaquina");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter titulo = new SqlParameter();
            titulo.ParameterName = "@ModeloMaquina";
            titulo.Value = dto.modeloMaquina;
            titulo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(titulo);

            IDataParameter ime = new SqlParameter();
            ime.ParameterName = "@IMEI";
            ime.Value = dto.imei;
            ime.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ime);

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@NrSerieMaquina";
            data.Value = dto.nrSerieMaquina;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter descricao = new SqlParameter();
            descricao.ParameterName = "@IdTipo";
            descricao.Value = dto.idTipo;
            descricao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(descricao);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@IdAluno";
            situacao.Value = dto.idAluno;
            situacao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            IDataParameter idMaq = new SqlParameter();
            idMaq.ParameterName = "@IdMaquina";
            idMaq.Value = dto.idMaquina;
            idMaq.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(idMaq);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void deleteMaquina(MaquinaDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"DELETE Maquina WHERE IdMaquina = @IdMaquina");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter idMaq = new SqlParameter();
            idMaq.ParameterName = "@IdMaquina";
            idMaq.Value = dto.idMaquina;
            idMaq.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(idMaq);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }


        internal DataTable searchMaquinaByIdAluno(MaquinaDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"Select 
	                        TipoMaquina.IdTipo, TipoMaquina.DescricaoTipo, 
	                        Maquina.ModeloMaquina, Maquina.NrSerieMaquina,
	                        Maquina.IdMaquina, Maquina.IdAluno, Maquina.IMEI
                        From TipoMaquina
	                        inner join Maquina 
                            on TipoMaquina.IdTipo = Maquina.IdTipo
                        Where
	                        Maquina.IdAluno = @idAluno order by TipoMaquina.IdTipo");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@IdAluno";
            situacao.Value = dto.idAluno;
            situacao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchMaquinaByIdTipoAndIdAluno(MaquinaDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"Select 
	                        TipoMaquina.IdTipo, TipoMaquina.DescricaoTipo, 
	                        Maquina.ModeloMaquina, Maquina.NrSerieMaquina,
	                        Maquina.IdMaquina, Maquina.IdAluno, Maquina.IMEI
                        From TipoMaquina
	                        inner join Maquina 
                            on TipoMaquina.IdTipo = Maquina.IdTipo
                        Where
	                        Maquina.IdAluno = @idAluno 
                            and Maquina.IdTipo = @idTipo order by TipoMaquina.IdTipo");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@IdAluno";
            situacao.Value = dto.idAluno;
            situacao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            IDataParameter tipo = new SqlParameter();
            tipo.ParameterName = "@IdTipo";
            tipo.Value = dto.idTipo;
            tipo.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(tipo);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable allMachines()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT 
	                        TipoMaquina.DescricaoTipo,
	                        Maquina.ModeloMaquina,
	                        Maquina.NrSerieMaquina,
	                        Aluno.Nome,
	                        Aluno.Email,
                            Aluno.Numero,
                            Maquina.IMEI
                        FROM
	                        Maquina
	                        INNER JOIN Aluno
		                        ON Maquina.IdAluno = Aluno.IdAluno
	                        INNER JOIN TipoMaquina
		                        ON TipoMaquina.IdTipo = Maquina.IdTipo
                        WHERE ANO=2015
                        ORDER BY Aluno.Nome");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }
    }
}
