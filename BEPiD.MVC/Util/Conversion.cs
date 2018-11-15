using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.Util
{
    public static class Conversion
    {
         /// <summary>
        /// Converte um valor para inteiro
        /// </summary>
        /// <param name="value">Valor a converter</param>
        /// <returns>Inteiro</returns>
        public static int ToInteger(object value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Converte um dado para long
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <returns>Retorna o resultado da operação ou 0 se falhar</returns>
        public static long ToLong(object value)
        {
            try
            {
                return Convert.ToInt64(value);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Converte um dado para Boolean
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <returns>Retorna o resultado da operação ou 0 se falhar</returns>
        public static Boolean ToBoolean(object value)
        {
            try
            {
                return Convert.ToBoolean(value);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Converte um dado para string
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <returns>Retorna o resultado da operação ou vazio se falhar</returns>
        public static string ToString(object value)
        {
            try
            {
                return Convert.ToString(value);
            }
            catch
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// Converte um double para string considerando um número exato de casas decimais
        /// </summary>
        /// <param name="value">Double a converter</param>
        /// <param name="decimals">Número de casas decimais</param>
        /// <returns>String</returns>
        public static string ToString(double value, int decimals)
        {
            try
            {
                if (value != 0)
                {
                    string[] ret = Convert.ToString(Math.Round(value, decimals)).Split(',');
                    if (ret.Length == 1)
                        return ret[0] + ",00";

                    if (ret.Length == 2)
                        return ret[0] + "," + ret[1].PadRight(decimals, '0');

                    return ToString(value);
                }
                else
                {
                    return ToString(value);
                }
            }
            catch
            {
                return ToString(value);
            }
        }

        public static char ToChar(object value)
        {
            try
            {
                return Convert.ToChar(value);
            }
            catch
            {
                return Convert.ToChar(0);
            }
        }


        /// <summary>
        /// Converte para o formato de data
        /// </summary>
        /// <param name="value">data</param>
        /// <returns>datetime</returns>
        public static DateTime ToDateTime(object value)
        {
            try
            {
                return Convert.ToDateTime(value);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Converte para decimal
        /// </summary>
        public static Decimal ToDecimal(object value)
        {
            try
            {
                return Convert.ToDecimal(value);
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// Converte para decimal
        /// </summary>
        public static double ToDouble(object value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch
            {
                return 0;
            }
        }

        public static string FormatString(string Value, TypeString tType)
        {
            try
            {
                switch (tType)
                {
                    case TypeString.CNPJ:
                        return string.Format("{0}.{1}.{2}/{3}-{4}", Value.Substring(0, 2), Value.Substring(2, 3), Value.Substring(5, 3), Value.Substring(8, 4), Value.Substring(12, 2));
                    case TypeString.CPF:
                        return string.Format("{0}.{1}.{2}-{3}", Value.Substring(0, 3), Value.Substring(3, 3), Value.Substring(6, 3), Value.Substring(9, 2));
                    case TypeString.Date:
                        if (Convert.ToDateTime(Value) == Convert.ToDateTime("1/1/1900"))
                            return string.Empty;
                        else
                            return Convert.ToDateTime(Value).ToString("dd/MM/yyyy");
                    case TypeString.Numeric:
                        return Convert.ToDouble(Value).ToString("#,##0.00");
                    case TypeString.Int:
                        return Convert.ToInt64(Value).ToString("#,##0");
                    case TypeString.Text:
                        return Value;
                    case TypeString.CEP:
                        return string.Format("{0}.{1}-{2}", Value.Substring(0, 2), Value.Substring(2, 3), Value.Substring(5, 3));
                    case TypeString.Telephone:
                        Value = Value.Replace("-", "").Replace(" ", "").Replace(".", "");
                        return string.Format("{0}-{1}", Value.Substring(0, Value.Length - 4), Value.Substring(Value.Length - 4, 4));
                    case TypeString.Currency:
                        return Convert.ToDouble(Value).ToString("C");
                    default:
                        return Value;
                }

            }
            catch
            {
                return Value;
            }
        }
    }
    public enum TypeString
    {
        Text,
        Numeric,
        CNPJ,
        CPF,
        Date,
        Int,
        CEP,
        Telephone,
        Currency
    }

}
