using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;

namespace BEPiD.Business.Util
{
    public static class Validacao
    {

        public static bool isInscricaoEncerrada(int day, int mounth, int ano)
        {
            //verifica a hora e data para encerrar as inscricoes.
            if (DateTime.Now.Day >= day && DateTime.Now.Month >= mounth && DateTime.Now.Year >= ano)
                return true;
            else
                return false;
        }

        public static bool IsValidCPF(object value)
        {
            string noMaskValue = Conversion.ToString(value).Replace(".", "").Replace("-", "");

            //if (noMaskValue.Length == 11)
                return IsValidCPF(value, false);
            //else
                //return IsValidCNPJ(value, false);

        }


        public static bool IsValidCPF(object value, bool IsEmpty)
        {
            try
            {
                string cpf = Conversion.ToString(value).Replace(".", "").Replace("-", "");

                if (cpf.Length != 11)
                    return false;

                for (int i = 0; i < 10; i++)
                    if (Conversion.ToDouble(cpf) == i * 11111111111)
                        return false;

                string rcpf1 = cpf.Substring(0, 9);
                string rcpf2 = cpf.Substring(9, 2);
                int d1 = 0;

                for (int i = 0; i < 9; i++)
                    d1 += Conversion.ToInteger(rcpf1.Substring(i, 1)) * (10 - i);
                d1 = 11 - (d1 % 11);
                if (d1 > 9) d1 = 0;

                if (Conversion.ToInteger(rcpf2.Substring(0, 1)) != d1)
                    return false;

                d1 *= 2;

                for (int i = 0; i < 9; i++)
                    d1 += Conversion.ToInteger(rcpf1.Substring(i, 1)) * (11 - i);
                d1 = 11 - (d1 % 11);
                if (d1 > 9) d1 = 0;

                if (Conversion.ToInteger(rcpf2.Substring(1, 1)) != d1)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
