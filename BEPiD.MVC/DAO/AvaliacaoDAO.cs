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
    internal class AvaliacaoDAO : Context
    {
        internal DataTable searchCountAvaliacao(AvaliacaoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT 
	                        distinct(tipoAvaliacao), 
	                        COUNT(0) as contador
                        FROM
	                        Avaliacao 
                        WHERE IdAluno=@IdAluno
                        group by TipoAvaliacao");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@IdAluno";
            situacao.Value = dto.idAluno;
            situacao.DbType = System.Data.DbType.Int32;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchAvaliacaoByIdAluno(AvaliacaoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT
	                        *
                        FROM
	                        Avaliacao 
	                        INNER JOIN Professor
		                        ON Professor.IdProfessor = Avaliacao.IdProfessor
	                        INNER JOIN Aluno
		                        ON Aluno.IdAluno = Avaliacao.idAluno
                        WHERE
	                        Avaliacao.IdAluno = @IdAluno
                        ORDER BY Avaliacao.DataAvaliacao desc");

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

        internal DataTable searchAvaliacao(AvaliacaoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT
	                        *
                        FROM
	                        Avaliacao 
	                        INNER JOIN Professor
		                        ON Professor.IdProfessor = Avaliacao.IdProfessor
	                        INNER JOIN Aluno
		                        ON Aluno.IdAluno = Avaliacao.idAluno
                        WHERE
	                        IdProfessor = @IdProfessor
	                        AND TipoAvaliacao = @TipoAvaliacao
                        ORDER BY Avaliacao.DataAvaliacao desc");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@IdProfessor";
            situacao.Value = dto.idProfessor;
            situacao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);
            
            IDataParameter senha = new SqlParameter();
            senha.ParameterName = "@TipoAvaliacao";
            senha.Value = dto.tipoAvaliacao;
            senha.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(senha);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal void insertMaquina(AvaliacaoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"INSERT INTO Avaliacao (dataAvaliacao, idProfessor, AssuntoAvaliacao, TipoAvaliacao, MensagemAvaliacao, IdAluno)
                        VALUES (@dataAvaliacao, @idProfessor, @AssuntoAvaliacao, @TipoAvaliacao, @MensagemAvaliacao, @IdAluno)");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter titulo = new SqlParameter();
            titulo.ParameterName = "@dataAvaliacao";
            titulo.Value = dto.dataAvaliacao;
            titulo.DbType = System.Data.DbType.Date;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(titulo);

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@idProfessor";
            data.Value = dto.idProfessor;
            data.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter descricao = new SqlParameter();
            descricao.ParameterName = "@AssuntoAvaliacao";
            descricao.Value = dto.assuntoAvaliacao;
            descricao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(descricao);

            IDataParameter tipo = new SqlParameter();
            tipo.ParameterName = "@TipoAvaliacao";
            tipo.Value = dto.tipoAvaliacao;
            tipo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(tipo);

            IDataParameter mensagem = new SqlParameter();
            mensagem.ParameterName = "@MensagemAvaliacao";
            mensagem.Value = dto.mensagemAvaliacao;
            mensagem.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(mensagem);

            IDataParameter aluno = new SqlParameter();
            aluno.ParameterName = "@IdAluno";
            aluno.Value = dto.idAluno;
            aluno.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(aluno);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }
    }
}
