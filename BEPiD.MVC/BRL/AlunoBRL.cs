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
    public class AlunoBRL
    {
        private AlunoDAO _alunoDAO;

        public AlunoBRL()
        {
            if (_alunoDAO == null)
                _alunoDAO = new AlunoDAO();
        }

        public DataTable buscaAlunosParaEnvioDeEmail(AlunoDTO dto, string sql, int? idAluno)
        {
            try
            {
                return _alunoDAO.buscaAlunosParaEnvioDeEmail(dto, sql, idAluno);
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAlunoByCPF(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.searchAlunoByCPF(dto);
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAlunosCompraDevices(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.searchAlunosCompraDevices(dto);
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable allUserInscricao(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.allUserInscricao(dto);
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable alunosSelecionadoParaEntrevista()
        {
            try
            {
                return _alunoDAO.alunosSelecionadoParaEntrevista();
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAlunoInscricao(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.searchAlunoInscricao(dto);
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public Boolean insertAlunoInscricao(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.insertAlunoInscricao(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public Boolean verifyCPFAndEmail(AlunoDTO dto)
        {
            try
            {
                DataTable dtTotal = _alunoDAO.verifyCPFAndEmail(dto);
                if (dtTotal != null && dtTotal.Rows.Count > 0)
                    if (dtTotal.Rows[0][0].ToString().Equals("0"))
                        return false;
                    else
                        return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public String searchTotalAlunoInscricao(AlunoDTO dto)
        {
            try
            {
                DataTable dtTotal = _alunoDAO.searchTotalAlunoInscricao(dto);
                if (dtTotal != null && dtTotal.Rows.Count > 0)
                {
                    return dtTotal.Rows[0][0].ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAlunoByAno(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.searchAlunoByAno(dto);
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAlunoByAno2014E2015()
        {
            try
            {
                return _alunoDAO.searchAlunoByAno2014E2015();
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAlunosGeral(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.searchAlunosGeral(dto);
            }
             catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public Boolean updateAluno(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAluno(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public Boolean updateAlunoNumeroMaquinaImagem(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAlunoNumeroMaquinaImagem(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public Boolean updateAlunoAceiteMaquina(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAlunoAceiteMaquina(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public bool updateAlunoAceiteOutorga(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAlunoAceiteOutorga(dto);
                return true;
            }
            catch (Exception ex)
            {

                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public Boolean updateAlunoAceiteDadosImagem(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAlunoAceiteDadosImagem(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public bool updateAlunoAceiteTermo(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAlunoAceiteTermo(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public bool updateAlunoSituacao(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAlunoSituacaoByEmail(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public DataTable searchAlunoByEmail(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.searchAlunoByEmail(dto);
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public Boolean updateAlunoSenhaByEmaileId(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAlunoSenhaByEmaileId(dto);
                return true;
            }
            catch (Exception ex)
            {
                var metodo = this.GetType().FullName + "." + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                var classe = this.GetType().Name.ToString();
                throw new Exception("Atenção: aconteceu um erro na classe: " + classe + " e método: " + metodo + ", tente novamente. <Br> Erro: " + ex.Message.ToString() + ex.Source.ToString() + ex.StackTrace.ToString() + ex.Source.ToString(), ex.InnerException);
            }
        }

        public bool updateAlunoSituacaoById(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.updateAlunoSituacaoById(dto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable allUser()
        {
            try
            {
                return _alunoDAO.allUser();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchDadosPrincipais(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.searchDadosPrincipais(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable searchUserLogin(AlunoDTO dto)
        {
            try
            {
                return _alunoDAO.searchUserLogin(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool insertAluno(AlunoDTO dto)
        {
            try
            {
                _alunoDAO.insertAluno(dto);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
