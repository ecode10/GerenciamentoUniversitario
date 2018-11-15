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
    internal class AlunoDAO : Context{

        internal DataTable searchAlunoByCPF(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT IdAluno FROM Aluno WHERE CPF=@Cpf and Ano = @ano");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            if (dto.ano != 0)
            {
                IDataParameter nome = new SqlParameter();
                nome.ParameterName = "@ano";
                nome.Value = dto.ano;
                nome.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(nome);
            }

            if (!String.IsNullOrEmpty(dto.cpf))
            {
                IDataParameter situacao = new SqlParameter();
                situacao.ParameterName = "@cpf";
                situacao.Value = dto.cpf;
                situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(situacao);
            }

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchAlunosCompraDevices(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT IdAluno,
	            Numero, Nome, DataNascimento, Endereco, CEP, Cidade, Estado, Telefone, Celular, CPF, Email, CPF, Identidade, orgao,
	            dataexpedicaoidentidade, Substring(
	            (
		            SELECT ' ' + m.nrSerieMaquina +  ' - ' as [text()]
		            FROM Maquina m
		            WHERE m.IdAluno = a.IdAluno
		            FOR XML PATH ('') 
	            ), 2, 1000) NrSerie
            FROM
	            Aluno a
            WHERE
	            a.ano=@ano and situacao=@situacao
            ORDER BY a.Nome");

             SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            if (dto.ano!=0)
            {
                IDataParameter nome = new SqlParameter();
                nome.ParameterName = "@ano";
                nome.Value = dto.ano;
                nome.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(nome);
            }

            if (!String.IsNullOrEmpty(dto.situacao))
            {
                IDataParameter situacao = new SqlParameter();
                situacao.ParameterName = "@situacao";
                situacao.Value = dto.situacao;
                situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(situacao);
            }

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }


        internal DataTable searchAlunosGeral(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@" select distinct aluno.IdAluno, nome, aluno.Foto, Email, aluno.identidade, aluno.numero, Telefone, Celular, Endereco, Cidade, Estado, NomeUniversidade, aluno.Situacao, aluno.Numero, aluno.CPF, aluno.BancoNome, aluno.BancoNr, aluno.Agencia, aluno.Conta, aluno.Ano, AlunoTipo.DescricaoTipoAluno, AlunoTipo.idTipoAluno from aluno
	                        left join avaliacao 
		                        on aluno.idAluno = avaliacao.idAluno
                            inner join AlunoTipo 
		                        on Aluno.IdTipoAluno = AlunoTipo.IdTipoAluno
                        WHERE 1=1 ");

            if(!String.IsNullOrEmpty(dto.nome))
                str.Append(@" AND Nome like @nome ");

            if(!String.IsNullOrEmpty(dto.situacao))
                str.Append(@" AND Situacao = @situacao ");

            if (dto.idTipoAluno != 0)
                str.Append(@" AND AlunoTipo.IdTipoAluno = @idTipoAluno");

            if(dto.ano!=0)
                str.Append(@" AND Ano = @ano ");

            if (dto.idProfessor != 0)
                str.Append(@" AND IdProfessor = @IdProfessor" );

            if (!String.IsNullOrEmpty(dto.tipoAvaliacao))
                str.Append(@" AND TipoAvaliacao = @tipoAvaliacao");

            str.Append(@" Order by Nome ");


            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;


            if (dto.idTipoAluno !=0)
            {
                IDataParameter idtipoaluno = new SqlParameter();
                idtipoaluno.ParameterName = "@idTipoAluno";
                idtipoaluno.Value = dto.idTipoAluno;
                idtipoaluno.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(idtipoaluno);
            }

            if (!String.IsNullOrEmpty(dto.nome))
            {
                IDataParameter nome = new SqlParameter();
                nome.ParameterName = "@nome";
                nome.Value = "%" + dto.nome + "%";
                nome.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(nome);
            }

            if (!String.IsNullOrEmpty(dto.situacao))
            {
                IDataParameter situacao = new SqlParameter();
                situacao.ParameterName = "@situacao";
                situacao.Value = dto.situacao;
                situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(situacao);
            }

            if (dto.ano!=0)
            {
                IDataParameter ano = new SqlParameter();
                ano.ParameterName = "@ano";
                ano.Value = dto.ano;
                ano.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(ano);
            }

            if (dto.idProfessor != 0)
            {
                IDataParameter professor = new SqlParameter();
                professor.ParameterName = "@IdProfessor";
                professor.Value = dto.idProfessor;
                professor.DbType = System.Data.DbType.Int32;
                dbCommand.Parameters.Add(professor);
            }

            if (!String.IsNullOrEmpty(dto.tipoAvaliacao))
            {
                IDataParameter avaliacao = new SqlParameter();
                avaliacao.ParameterName = "@tipoAvaliacao";
                avaliacao.Value = dto.tipoAvaliacao;
                avaliacao.DbType = System.Data.DbType.String;
                dbCommand.Parameters.Add(avaliacao);
            }

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchAlunoByAno(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT * FROM Aluno
                         WHERE Ano = @ano");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@ano";
            email.Value = dto.ano;
            email.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchAlunoByAno2014E2015()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT * FROM Aluno where Ano in ('2014', '2015', '2016')
                            and Situacao= 'O' 
                            and Password is not null");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable verifyCPFAndEmail(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT count(0) FROM Aluno
                         WHERE CPF= @CPF and Email = @Email and Situacao= @Situacao and Ano = @ano");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@email";
            email.Value = dto.email;
            email.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            IDataParameter cpf = new SqlParameter();
            cpf.ParameterName = "@cpf";
            cpf.Value = dto.cpf;
            cpf.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(cpf);

            IDataParameter ano = new SqlParameter();
            ano.ParameterName = "@ano";
            ano.Value = dto.ano;
            ano.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ano);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@situacao";
            situacao.Value = dto.situacao;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchTotalAlunoInscricao(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT count(0) FROM Aluno
                         WHERE Situacao= @Situacao and Ano = @ano");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter ano = new SqlParameter();
            ano.ParameterName = "@ano";
            ano.Value = dto.ano;
            ano.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ano);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@situacao";
            situacao.Value = dto.situacao;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }


        internal DataTable alunosSelecionadoParaEntrevista()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"select * from aluno where email in ('afonso_lucas1994@hotmail.com','amiramaythe@hotmail.com','arthur_ravin@hotmail.com','augustohenriquealmeidasilva@gmail.com','bruno3chagas@gmail.com','eunotomocaf@gmail.com','eduardo.torresm@hotmail.com','vitaldu@gmail.com','winstoncire@gmail.com','liipe.frs@gmail.com','gbrvalerio@gmail.com','gabriel.mmi@hotmail.com','folameloma@gmail.com','gabrielrodriguesfaria97@gmail.com','geovannirock@gmail.com','guilhermebaldissera@hotmail.com','maxwellguilherme@gmail.com','almeidaws@outlook.com','gustavo_vollbrecht@hotmail.com.br','helena.simoes@me.com','higorcp18@gmail.com','nascimentohyago@gmail.com','ifm394@gmail.com','sjobom.italo@gmail.com','italohqueiroz@gmail.com','jessicasa.comunicacao@gmail.com','joaovitornaru@hotmail.com','jonascl98@gmail.com','julianafurtado64@gmail.com','mml_leo@hotmail.com','theleticiadidier@gmail.com','luis.gustavo3013@hotmail.com','maisa.milena@gmail.com','marcosfellipec@gmail.com','matheus.klementt@gmail.com','matheusbsb2009@hotmail.com','matheus.mbispo@gmail.com','omatheus015@gmail.com','math222ribeiro@hotmail.com','nery.mik@gmail.com','miguelpimentel2013@gmail.xom','paulo.costa96@yahoo.com','pedro_hoc@hotmail.com','pedrojean.matriz@gmail.com','naner98@hotmail.com.br','ricardorachaus@gmail.com','samyr.matriz@gmail.com','oliveiratayna96@gmail.com','thi_wn@hotmail.com','krevi2796@gmail.com')");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            //IDataParameter ano = new SqlParameter();
            //ano.ParameterName = "@ano";
            //ano.Value = dto.ano;
            //ano.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            //dbCommand.Parameters.Add(ano);

            //IDataParameter situacao = new SqlParameter();
            //situacao.ParameterName = "@situacao";
            //situacao.Value = dto.situacao;
            //situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            //dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable buscaAlunosParaEnvioDeEmail(AlunoDTO dto, string sql, int? idAluno)
        {
            StringBuilder str = new StringBuilder();
            str.Append(sql);

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter ano = new SqlParameter();
            ano.ParameterName = "@ano";
            ano.Value = dto.ano;
            ano.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ano);

            IDataParameter tipoAluno = new SqlParameter();
            tipoAluno.ParameterName = "@IdTipoAluno";
            tipoAluno.Value = dto.idTipoAluno;
            tipoAluno.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(tipoAluno);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@situacao";
            situacao.Value = dto.situacao;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            if (idAluno != 0)
            {
                IDataParameter idAlun = new SqlParameter();
                idAlun.ParameterName = "@IdAluno";
                idAlun.Value = idAluno;
                idAlun.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(idAlun);
            } 

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchAlunoInscricao(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT Nome, Email, Telefone, Celular, Endereco, Cidade, Estado, NomeUniversidade, replace(replace(cpf, '.', ''), '-','') as CPF, 
                            Identidade, Orgao, DataNascimento, CEP, EstadoCivil, Nacionalidade, Ano, Sexo, NomedaMae, 
                            LeituraIngles, EscritaIngles, ComunicacaoIngles, Curso, Semestre, Formatura, Ocupacao, Naturalidade,
                            DataExpedicaoIdentidade 
                        FROM Aluno
                         WHERE Situacao= @Situacao and Ano = @ano and IdTipoAluno=2 ORDER BY Nome");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter ano = new SqlParameter();
            ano.ParameterName = "@ano";
            ano.Value = dto.ano;
            ano.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ano);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@situacao";
            situacao.Value = dto.situacao;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        
        internal DataTable searchDadosPrincipais(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT * FROM Aluno
                         WHERE idAluno = @id");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@id";
            email.Value = dto.idAluno;
            email.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchAlunoByEmail(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT * FROM Aluno WHERE email = @email and situacao = @situacao");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@email";
            email.Value = dto.email;
            email.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            IDataParameter sit = new SqlParameter();
            sit.ParameterName = "@situacao";
            sit.Value = dto.situacao;
            sit.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(sit);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable allUser()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT * FROM Aluno WHERE Situacao = @situacao order by Numero, Nome ");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@situacao";
            email.Value = "A";
            email.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable allUserInscricao(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT IdAluno, UPPER(Nome) as Nome, email, telefone, celular, endereco, cidade, estado, nomeuniversidade, identidade, orgao, 
                            aceiteoutorga,aceitemaquina, aceitedados, banconome,banconr, agencia, conta, datanascimento, situacao, cep, 
                            estadocivil,nacionalidade, foto, numero,ano, sexo, dataexpedicaoidentidade,nomedamae,leituraingles, escritaingles,
                            comunicacaoingles,curso, semestre,formatura, ocupacao, naturalidade, Aluno.idtipoaluno, linkportifolio, 
                            SUBSTRING(CPF,1,3) + '.' + SUBSTRING(CPF,4,3) + '.' + SUBSTRING(CPF,7,3) + '-'+ SUBSTRING(CPF,10,2) as CPF, 
                            AlunoTipo.DescricaoTipoAluno
                        FROM Aluno INNER JOIN AlunoTipo ON Aluno.IdTipoAluno = AlunoTipo.IdTipoAluno
                        WHERE Situacao = @situacao and Ano = @ano ");

            if (!String.IsNullOrEmpty(dto.nome))
                str.Append(@" and Nome like @nome ");

            if(!String.IsNullOrEmpty(dto.nomeUniversidade))
                str.Append(@" and nomeUniversidade = @universidade ");

            if (dto.idTipoAluno !=0)
                str.Append(" and Aluno.IdTipoAluno = @idAlunoTipo ");

            if (!String.IsNullOrEmpty(dto.sexo))
                str.Append(@" and sexo = @sexo ");

            str.Append(@" order by Nome, AlunoTipo.DescricaoTipoAluno ");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@situacao";
            email.Value = dto.situacao;
            email.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            IDataParameter ano = new SqlParameter();
            ano.ParameterName = "@ano";
            ano.Value = dto.ano;
            ano.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ano);

            if (!String.IsNullOrEmpty(dto.nome))
            {
                IDataParameter nome = new SqlParameter();
                nome.ParameterName = "@nome";
                nome.Value = "%" + dto.nome + "%";
                nome.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(nome);
            }

            if (!String.IsNullOrEmpty(dto.sexo))
            {
                IDataParameter se = new SqlParameter();
                se.ParameterName = "@sexo";
                se.Value = dto.sexo;
                se.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
                dbCommand.Parameters.Add(se);
            }

            if (!String.IsNullOrEmpty(dto.nomeUniversidade))
            {
                IDataParameter universidae = new SqlParameter();
                universidae.ParameterName = @"universidade";
                universidae.Value = dto.nomeUniversidade;
                universidae.DbType = System.Data.DbType.String;
                dbCommand.Parameters.Add(universidae);
            }

            if (dto.idTipoAluno !=0)
            {
                IDataParameter idAlunoTipo = new SqlParameter();
                idAlunoTipo.ParameterName = @"idAlunoTipo";
                idAlunoTipo.Value = dto.idTipoAluno;
                idAlunoTipo.DbType = System.Data.DbType.Int32;
                dbCommand.Parameters.Add(idAlunoTipo);
            }

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal DataTable searchUserLogin(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"SELECT IdAluno, Email, Nome, Celular, CPF, Situacao FROM Aluno
                                WHERE email = @email AND Password = @pw and Situacao = @situacao"); //and Ano = @ano

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            //IDataParameter anoAluno = new SqlParameter();
            //anoAluno.ParameterName = "@ano";
            //anoAluno.Value = dto.ano;
            //anoAluno.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            //dbCommand.Parameters.Add(anoAluno);

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@email";
            email.Value = dto.email;
            email.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            IDataParameter pw = new SqlParameter();
            pw.ParameterName = "@pw";
            pw.Value = dto.password;
            pw.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(pw);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@situacao";
            situacao.Value = "A";
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            database.GetSourceConnection();
            return database.ExecutaDataSetParameter(dbCommand).Tables[0];
        }

        internal void insertAluno(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"INSERT INTO Aluno (Nome, Email, Telefone, Celular, Endereco, Cidade, Estado, NomeUniversidade, CPF, Identidade, 
                                            Orgao, Password, BancoNome, BancoNr, Agencia, Conta, DataNascimento, Situacao, cep, estadocivil, nacionalidade) 
                            VALUES (@Nome, @email, @telefone, @celular, @endereco, @cidade, @estado, @nomeUniversidade, @cpf, @identidade, 
                                            @orgao, @password, @bancoNome, @bancoNr, @agencia, @conta, @dataNascimento, @Situacao, @cep, @estadocivil, @nacionalidade)");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter cep = new SqlParameter();
            cep.ParameterName = "@cep";
            cep.Value = dto.cep;
            cep.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(cep);

            IDataParameter estadoCivil = new SqlParameter();
            estadoCivil.ParameterName = "@estadocivil";
            estadoCivil.Value = dto.estadoCivil;
            estadoCivil.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(estadoCivil);

            IDataParameter nacionalidade = new SqlParameter();
            nacionalidade.ParameterName = "@nacionalidade";
            nacionalidade.Value = dto.nacionalidade;
            nacionalidade.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nacionalidade);

            IDataParameter titulo = new SqlParameter();
            titulo.ParameterName = "@nome";
            titulo.Value = dto.nome;
            titulo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(titulo);

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@email";
            data.Value = dto.email;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter descricao = new SqlParameter();
            descricao.ParameterName = "@telefone";
            descricao.Value = dto.telefone;
            descricao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(descricao);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@celular";
            situacao.Value = dto.celular;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            IDataParameter chaveUsuario = new SqlParameter();
            chaveUsuario.ParameterName = "@endereco";
            chaveUsuario.Value = dto.endereco;
            chaveUsuario.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(chaveUsuario);

            IDataParameter tipo = new SqlParameter();
            tipo.ParameterName = "@cidade";
            tipo.Value = dto.cidade;
            tipo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(tipo);

            IDataParameter link = new SqlParameter();
            link.ParameterName = "@estado";
            link.Value = dto.estado;
            link.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(link);

            IDataParameter nomeUniversidad = new SqlParameter();
            nomeUniversidad.ParameterName = "@nomeUniversidade";
            nomeUniversidad.Value = dto.nomeUniversidade;
            nomeUniversidad.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nomeUniversidad);

            IDataParameter cpf = new SqlParameter();
            cpf.ParameterName = "@cpf";
            cpf.Value = dto.cpf;
            cpf.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(cpf);

            IDataParameter identidade = new SqlParameter();
            identidade.ParameterName = "@identidade";
            identidade.Value = dto.identidade;
            identidade.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(identidade);

            IDataParameter orgao = new SqlParameter();
            orgao.ParameterName = "@orgao";
            orgao.Value = dto.orgao;
            orgao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(orgao);

            IDataParameter pass = new SqlParameter();
            pass.ParameterName = "@password";
            pass.Value = dto.password;
            pass.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(pass);

            IDataParameter bancoNome = new SqlParameter();
            bancoNome.ParameterName = "@bancoNome";
            bancoNome.Value = dto.bancoNome;
            bancoNome.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(bancoNome);

            IDataParameter bancoNr = new SqlParameter();
            bancoNr.ParameterName = "@bancoNr";
            bancoNr.Value = dto.bancoNumero;
            bancoNr.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(bancoNr);

            IDataParameter agencia = new SqlParameter();
            agencia.ParameterName = "@agencia";
            agencia.Value = dto.agencia;
            agencia.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(agencia);

            IDataParameter conta = new SqlParameter();
            conta.ParameterName = "@conta";
            conta.Value = dto.conta;
            conta.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(conta);

            IDataParameter dataNascimento = new SqlParameter();
            dataNascimento.ParameterName = "@dataNascimento";
            dataNascimento.Value = dto.dataNascimento;
            dataNascimento.DbType = System.Data.DbType.Date;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(dataNascimento);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@situacao";
            situac.Value = "I";
            situac.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void insertAlunoInscricao(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"INSERT INTO Aluno (Nome, Email, Telefone, Celular, Endereco, Cidade, Estado, NomeUniversidade, CPF, Identidade, 
                                            Orgao, DataNascimento, Situacao, cep, estadocivil, nacionalidade,
                                            nomeDaMae, Sexo, DataExpedicaoIdentidade, LeituraIngles, EscritaIngles, ComunicacaoIngles, Curso, Semestre, Formatura, 
                                            Ocupacao, ano, naturalidade, idTipoAluno, linkPortifolio) 
                    VALUES (@Nome, @email, @telefone, @celular, @endereco, @cidade, @estado, @nomeUniversidade, @cpf, @identidade, 
                                    @orgao, @dataNascimento, @Situacao, @cep, @estadocivil, @nacionalidade,
                                    @nomeDaMae, @sexo, @DataExpedicaoIdentidade, @LeituraIngles, @EscritaIngles, @ComunicacaoIngles, @Curso, @Semestre, @Formatura, 
                                            @Ocupacao, @ano, @naturalidade, @idTipoAluno, @linkPortifolio)");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter natural = new SqlParameter();
            natural.ParameterName = "@naturalidade";
            natural.Value = dto.naturalidade;
            natural.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(natural);

            IDataParameter ano = new SqlParameter();
            ano.ParameterName = "@ano";
            ano.Value = dto.ano;
            ano.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ano);

            IDataParameter ocupacao = new SqlParameter();
            ocupacao.ParameterName = "@Ocupacao";
            ocupacao.Value = dto.ocupacaoAtual;
            ocupacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(ocupacao);

            IDataParameter formatu = new SqlParameter();
            formatu.ParameterName = "@Formatura";
            formatu.Value = dto.previsaoFormatura;
            formatu.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(formatu);

            IDataParameter semestre = new SqlParameter();
            semestre.ParameterName = "@Semestre";
            semestre.Value = dto.semestre;
            semestre.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(semestre);

            IDataParameter curso = new SqlParameter();
            curso.ParameterName = "@Curso";
            curso.Value = dto.curso;
            curso.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(curso);

            IDataParameter comunica = new SqlParameter();
            comunica.ParameterName = "@ComunicacaoIngles";
            comunica.Value = dto.inglesComunicacaoVerbal;
            comunica.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(comunica);

            IDataParameter escrita = new SqlParameter();
            escrita.ParameterName = "@EscritaIngles";
            escrita.Value = dto.inglesEscrita;
            escrita.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(escrita);

            IDataParameter leitura = new SqlParameter();
            leitura.ParameterName = "@LeituraIngles";
            leitura.Value = dto.inglesLeitura;
            leitura.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(leitura);

            IDataParameter dataexped = new SqlParameter();
            dataexped.ParameterName = "@DataExpedicaoIdentidade";
            dataexped.Value = dto.dataDeExpedicao;
            dataexped.DbType = System.Data.DbType.Date;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(dataexped);

            IDataParameter sexo = new SqlParameter();
            sexo.ParameterName = "@sexo";
            sexo.Value = dto.sexo;
            sexo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(sexo);

            IDataParameter mae = new SqlParameter();
            mae.ParameterName = "@nomeDaMae";
            mae.Value = dto.nomeDaMae;
            mae.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(mae);

            IDataParameter cep = new SqlParameter();
            cep.ParameterName = "@cep";
            cep.Value = dto.cep;
            cep.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(cep);

            IDataParameter estadoCivil = new SqlParameter();
            estadoCivil.ParameterName = "@estadocivil";
            estadoCivil.Value = dto.estadoCivil;
            estadoCivil.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(estadoCivil);

            IDataParameter nacionalidade = new SqlParameter();
            nacionalidade.ParameterName = "@nacionalidade";
            nacionalidade.Value = dto.nacionalidade;
            nacionalidade.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nacionalidade);

            IDataParameter titulo = new SqlParameter();
            titulo.ParameterName = "@nome";
            titulo.Value = dto.nome;
            titulo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(titulo);

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@email";
            data.Value = dto.email;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter descricao = new SqlParameter();
            descricao.ParameterName = "@telefone";
            descricao.Value = dto.telefone;
            descricao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(descricao);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@celular";
            situacao.Value = dto.celular;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            IDataParameter chaveUsuario = new SqlParameter();
            chaveUsuario.ParameterName = "@endereco";
            chaveUsuario.Value = dto.endereco;
            chaveUsuario.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(chaveUsuario);

            IDataParameter tipo = new SqlParameter();
            tipo.ParameterName = "@cidade";
            tipo.Value = dto.cidade;
            tipo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(tipo);

            IDataParameter link = new SqlParameter();
            link.ParameterName = "@estado";
            link.Value = dto.estado;
            link.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(link);

            IDataParameter nomeUniversidad = new SqlParameter();
            nomeUniversidad.ParameterName = "@nomeUniversidade";
            nomeUniversidad.Value = dto.nomeUniversidade;
            nomeUniversidad.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nomeUniversidad);

            IDataParameter cpf = new SqlParameter();
            cpf.ParameterName = "@cpf";
            cpf.Value = dto.cpf;
            cpf.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(cpf);

            IDataParameter identidade = new SqlParameter();
            identidade.ParameterName = "@identidade";
            identidade.Value = dto.identidade;
            identidade.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(identidade);

            IDataParameter orgao = new SqlParameter();
            orgao.ParameterName = "@orgao";
            orgao.Value = dto.orgao;
            orgao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(orgao);

            IDataParameter dataNascimento = new SqlParameter();
            dataNascimento.ParameterName = "@dataNascimento";
            dataNascimento.Value = dto.dataNascimento;
            dataNascimento.DbType = System.Data.DbType.Date;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(dataNascimento);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@situacao";
            situac.Value = "P";
            situac.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            IDataParameter tipoAluno = new SqlParameter();
            tipoAluno.ParameterName = "@idTipoAluno";
            tipoAluno.Value = dto.idTipoAluno;
            tipoAluno.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(tipoAluno);

            IDataParameter linkPort = new SqlParameter();
            linkPort.ParameterName = "@linkPortifolio";
            linkPort.Value = dto.linkPortifolio;
            linkPort.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(linkPort);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }


        internal void updateAluno(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno SET Telefone=@Telefone, Celular=@Celular, Endereco=@Endereco,
                                        Cidade=@Cidade, Estado=@Estado, NomeUniversidade=@NomeUniversidade, Identidade=@Identidade, 
                                        Orgao=@Orgao, BancoNome=@BancoNome, BancoNr=@BancoNr, 
                                        Agencia=@Agencia, Conta=@Conta, cep=@cep, --DataNascimento=@DataNascimento, 
                                        estadocivil=@estadocivil, nacionalidade=@nacionalidade, nome=@nome, email=@email--,
                                        --DataExpedicaoIdentidade = @DataExpedicaoIdentidade
                         WHERE IdAluno = @IdAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@email";
            email.Value = dto.email;
            email.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            IDataParameter nomeAluno = new SqlParameter();
            nomeAluno.ParameterName = "@nome";
            nomeAluno.Value = dto.nome;
            nomeAluno.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nomeAluno);

            IDataParameter cep = new SqlParameter();
            cep.ParameterName = "@cep";
            cep.Value = dto.cep;
            cep.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(cep);

            IDataParameter estadoCivil = new SqlParameter();
            estadoCivil.ParameterName = "@estadocivil";
            estadoCivil.Value = dto.estadoCivil;
            estadoCivil.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(estadoCivil);

            IDataParameter nacionalidade = new SqlParameter();
            nacionalidade.ParameterName = "@nacionalidade";
            nacionalidade.Value = dto.nacionalidade;
            nacionalidade.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nacionalidade);

            IDataParameter descricao = new SqlParameter();
            descricao.ParameterName = "@telefone";
            descricao.Value = dto.telefone;
            descricao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(descricao);

            IDataParameter situacao = new SqlParameter();
            situacao.ParameterName = "@celular";
            situacao.Value = dto.celular;
            situacao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situacao);

            IDataParameter chaveUsuario = new SqlParameter();
            chaveUsuario.ParameterName = "@endereco";
            chaveUsuario.Value = dto.endereco;
            chaveUsuario.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(chaveUsuario);

            IDataParameter tipo = new SqlParameter();
            tipo.ParameterName = "@cidade";
            tipo.Value = dto.cidade;
            tipo.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(tipo);

            IDataParameter link = new SqlParameter();
            link.ParameterName = "@estado";
            link.Value = dto.estado;
            link.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(link);

            IDataParameter nomeUniversidad = new SqlParameter();
            nomeUniversidad.ParameterName = "@nomeUniversidade";
            nomeUniversidad.Value = dto.nomeUniversidade;
            nomeUniversidad.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(nomeUniversidad);

            IDataParameter identidade = new SqlParameter();
            identidade.ParameterName = "@identidade";
            identidade.Value = dto.identidade;
            identidade.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(identidade);

            IDataParameter orgao = new SqlParameter();
            orgao.ParameterName = "@orgao";
            orgao.Value = dto.orgao;
            orgao.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(orgao);

            //IDataParameter pass = new SqlParameter();
            //pass.ParameterName = "@DataExpedicaoIdentidade";
            //pass.Value = dto.dataDeExpedicao;
            //pass.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            //dbCommand.Parameters.Add(pass);

            IDataParameter bancoNome = new SqlParameter();
            bancoNome.ParameterName = "@bancoNome";
            bancoNome.Value = dto.bancoNome;
            bancoNome.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(bancoNome);

            IDataParameter bancoNr = new SqlParameter();
            bancoNr.ParameterName = "@bancoNr";
            bancoNr.Value = dto.bancoNumero;
            bancoNr.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(bancoNr);

            IDataParameter agencia = new SqlParameter();
            agencia.ParameterName = "@agencia";
            agencia.Value = dto.agencia;
            agencia.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(agencia);

            IDataParameter conta = new SqlParameter();
            conta.ParameterName = "@conta";
            conta.Value = dto.conta;
            conta.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(conta);

            //IDataParameter dataNascimento = new SqlParameter();
            //dataNascimento.ParameterName = "@dataNascimento";
            //dataNascimento.Value = dto.dataNascimento;
            //dataNascimento.DbType = System.Data.DbType.Date;//System.Data.DbType.Guid;
            //dbCommand.Parameters.Add(dataNascimento);

            IDataParameter idAluno = new SqlParameter();
            idAluno.ParameterName = "@idAluno";
            idAluno.Value = dto.idAluno;
            idAluno.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(idAluno);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateAlunoSituacaoByEmail(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno set Situacao = @situacao WHERE Email=@email");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@email";
            data.Value = dto.email;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@situacao";
            situac.Value = dto.situacao;
            situac.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateAlunoSituacaoById(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno set Situacao = @situacao WHERE IdAluno=@IdAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@IdAluno";
            data.Value = dto.idAluno;
            data.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@situacao";
            situac.Value = dto.situacao;
            situac.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateAlunoSenhaByEmaileId(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno set Password = @password WHERE Email=@Email and IdAluno=@IdAluno and Situacao=@situacao");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@IdAluno";
            data.Value = dto.idAluno;
            data.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter sit = new SqlParameter();
            sit.ParameterName = "@situacao";
            sit.Value = dto.situacao;
            sit.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(sit);

            IDataParameter email = new SqlParameter();
            email.ParameterName = "@Email";
            email.Value = dto.email;
            email.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(email);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@password";
            situac.Value = dto.password;
            situac.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateAlunoAceiteDadosImagem(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno set AceiteDados = @AceiteDados WHERE IdAluno=@IdAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@IdAluno";
            data.Value = dto.idAluno;
            data.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@AceiteDados";
            situac.Value = dto.aceiteDados;
            situac.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateAlunoNumeroMaquinaImagem(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno set Numero = @Numero, Foto = @Foto WHERE IdAluno=@IdAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@IdAluno";
            data.Value = dto.idAluno;
            data.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@Numero";
            if (dto.numero==0)
                situac.Value = DBNull.Value;
            else
                situac.Value = dto.numero;
            situac.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            IDataParameter foto = new SqlParameter();
            foto.ParameterName = "@Foto";
            foto.Value = dto.foto;
            foto.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(foto);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateAlunoAceiteTermo(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno set AceiteTermo = @AceiteTermo WHERE IdAluno=@IdAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@IdAluno";
            data.Value = dto.idAluno;
            data.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@AceiteTermo";
            situac.Value = dto.aceiteTermo;
            situac.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateAlunoAceiteOutorga(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno set AceiteOutorga = @AceiteOutorga WHERE IdAluno=@IdAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@AceiteOutorga";
            data.Value = dto.aceiteContrato;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@IdAluno";
            situac.Value = dto.idAluno;
            situac.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }

        internal void updateAlunoAceiteMaquina(AlunoDTO dto)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"UPDATE Aluno set AceiteMaquina = @Aceite WHERE IdAluno=@IdAluno");

            SqlCommand dbCommand = new SqlCommand(str.ToString());
            dbCommand.CommandType = CommandType.Text;

            IDataParameter data = new SqlParameter();
            data.ParameterName = "@Aceite";
            data.Value = dto.aceiteMaquina;
            data.DbType = System.Data.DbType.String;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(data);

            IDataParameter situac = new SqlParameter();
            situac.ParameterName = "@IdAluno";
            situac.Value = dto.idAluno;
            situac.DbType = System.Data.DbType.Int32;//System.Data.DbType.Guid;
            dbCommand.Parameters.Add(situac);

            database.GetSourceConnection();
            database.ExecutaNonQueryParameter(dbCommand);
        }
    }
}
