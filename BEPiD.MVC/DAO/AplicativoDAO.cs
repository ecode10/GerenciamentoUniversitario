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
    internal class AplicativoDAO : Context
    {
        internal void insertAplicativo(AplicativoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"INSERT INTO Aplicativo (IdCategoria, NomeAplicativo, LinkAplicativo, IdAluno, ImagemAplicativo, ImagemAplicativo1, ImagemAplicativo2, ImagemAplicativo3, Situacao, NomeGrupoAplicativo, Ano, Challenge, DescricaoAplicativo, DataPublicacaoAplicativo)
                            VALUES (@IdCategoria, @NomeAplicativo, @LinkAplicativo, @IdAluno, @ImagemAplicativo, @ImagemAplicativo1, @ImagemAplicativo2, @ImagemAplicativo3, @Situacao, @NomeGrupoAplicativo, @Ano, @Challenge, @DescricaoAplicativo, @DataPublicacaoAplicativo)");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter cep = new SqlParameter();
            cep.ParameterName = "@IdCategoria";
            cep.Value = dto.idCategoria;
            cep.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(cep);

            IDataParameter estadoCivil = new SqlParameter();
            estadoCivil.ParameterName = "@NomeAplicativo";
            estadoCivil.Value = dto.nomeAplicativo;
            estadoCivil.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(estadoCivil);

            IDataParameter ano = new SqlParameter();
            ano.ParameterName = "@Ano";
            ano.Value = dto.ano;
            ano.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ano);

            IDataParameter challenge = new SqlParameter();
            challenge.ParameterName = "@Challenge";
            challenge.Value = dto.challenge;
            challenge.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(challenge);

            IDataParameter nacionalidade = new SqlParameter();
            nacionalidade.ParameterName = "@LinkAplicativo";
            nacionalidade.Value = dto.linkAplicativo;
            nacionalidade.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nacionalidade);

            IDataParameter titulo = new SqlParameter();
            titulo.ParameterName = "@IdAluno";
            titulo.Value = dto.idAluno;
            titulo.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(titulo);

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@ImagemAplicativo";
            data.Value = dto.imagemAplicativo;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter img1 = new SqlParameter();
            img1.ParameterName = "@ImagemAplicativo1";
            img1.Value = dto.imagemAplicativo1;
            img1.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(img1);

            IDataParameter img2 = new SqlParameter();
            img2.ParameterName = "@ImagemAplicativo2";
            img2.Value = dto.imagemAplicativo2;
            img2.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(img2);

            IDataParameter img3 = new SqlParameter();
            img3.ParameterName = "@ImagemAplicativo3";
            img3.Value = dto.imagemAplicativo3;
            img3.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(img3);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@Situacao";
            situacao.Value = dto.situacao;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            IDataParameter nomegrupo = new SqlParameter();
            nomegrupo.ParameterName = "@NomeGrupoAplicativo";
            nomegrupo.Value = dto.nomeGrupoAplicativo;
            nomegrupo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nomegrupo);

            IDataParameter descricaoAplicativo = new SqlParameter();
            descricaoAplicativo.ParameterName = "@DescricaoAplicativo";
            descricaoAplicativo.Value = dto.descricaoAplicativo;
            descricaoAplicativo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(descricaoAplicativo);

            IDataParameter dataPublicacaoAplicativo = new SqlParameter();
            dataPublicacaoAplicativo.ParameterName = "@DataPublicacaoAplicativo";
            dataPublicacaoAplicativo.Value = dto.dataPublicacaoAplicativo;
            dataPublicacaoAplicativo.DbType = System.Data.DbType.DateTime;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(dataPublicacaoAplicativo);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }


        internal void deleteAplicativo(AplicativoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"DELETE Aplicativo where IdAplicativo = @IdAplicativo");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter cep = new SqlParameter();
            cep.ParameterName = "@IdAplicativo";
            cep.Value = dto.idAplicativo;
            cep.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(cep);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }


        internal DataTable searchAplicativo(AplicativoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@" SELECT Aplicativo.IdAplicativo, Aplicativo.ImagemAplicativo1, Aplicativo.ImagemAplicativo2, Aplicativo.ImagemAplicativo3, Aplicativo.NomeGrupoAplicativo, Aplicativo.IdCategoria, Aplicativo.NomeAplicativo, Aplicativo.LinkAplicativo, Aplicativo.IdAluno, Aplicativo.ImagemAplicativo, Categoria.NomeCategoria, Aplicativo.DescricaoAplicativo, Aplicativo.DataPublicacaoAplicativo, Aplicativo.Challenge, Aplicativo.Ano FROM Aplicativo 
                                INNER JOIN Categoria ON Categoria.IdCategoria = Aplicativo.IdCategoria WHERE 1=1 ");

            if(!String.IsNullOrEmpty(dto.nomeAplicativo))
                str.Append(@" AND NomeAplicativo like @nomeAplicativo ");

            if(dto.idAplicativo!=0)
                str.Append(@" AND Aplicativo.IdAplicativo = @IdAplicativo ");

            if(dto.idCategoria!=0)
                str.Append(@" AND Aplicativo.IdCategoria = @IdCategoria ");

            if (dto.idAluno != 0)
                str.Append(@" AND Aplicativo.IdAluno = @IdAluno ");

            if (!String.IsNullOrEmpty(dto.ano))
                str.Append(@" AND Aplicativo.ano = @ano ");

            str.Append(@" Order by newId()");


            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;


            if (!String.IsNullOrEmpty(dto.ano))
            {
                IDataParameter ano = new SqlParameter();
                ano.ParameterName = "@ano";
                ano.Value = dto.ano;
                ano.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(ano);
            }

            if (dto.idAluno != 0)
            {
                IDataParameter idAlun = new SqlParameter();
                idAlun.ParameterName = "@IdAluno";
                idAlun.Value = dto.idAluno;
                idAlun.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(idAlun);
            }

            if (!String.IsNullOrEmpty(dto.nomeAplicativo))
            {
                IDataParameter nome = new SqlParameter();
                nome.ParameterName = "@nomeAplicativo";
                nome.Value = "%" + dto.nomeAplicativo + "%";
                nome.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(nome);
            }

            if (dto.idCategoria!=0)
            {
                IDataParameter situacao = new SqlParameter();
                situacao.ParameterName = "@IdCategoria";
                situacao.Value = dto.idCategoria;
                situacao.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(situacao);
            }

            if (dto.idAplicativo != 0)
            {
                IDataParameter ano = new SqlParameter();
                ano.ParameterName = "@IdAplicativo";
                ano.Value = dto.idAplicativo;
                ano.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(ano);
            }

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }


        internal DataTable searchAplicativoTop()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@" SELECT TOP 12 Aplicativo.IdAplicativo, Aplicativo.NomeGrupoAplicativo, Aplicativo.IdCategoria, Aplicativo.NomeAplicativo, Aplicativo.LinkAplicativo, Aplicativo.IdAluno, Aplicativo.ImagemAplicativo, Categoria.NomeCategoria, Aplicativo.DescricaoAplicativo, Aplicativo.DataPublicacaoAplicativo, Aplicativo.Ano FROM Aplicativo 
                                INNER JOIN Categoria ON Categoria.IdCategoria = Aplicativo.IdCategoria WHERE 1=1 ");
            str.Append(@" Order by newId()");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        /// <summary>
        /// Retorna a quantidade de aplicativos publicados em cada categoria
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        internal DataTable searchAplicativoByCategoria()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@" SELECT
	                            COUNT(0) as contador,
	                            Categoria.NomeCategoria
                            FROM
	                            Aplicativo
	                            INNER JOIN Categoria
		                            ON Categoria.IdCategoria = Aplicativo.IdCategoria
                            WHERE 1=1
	                            GROUP BY Categoria.NomeCategoria");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

    }
}
