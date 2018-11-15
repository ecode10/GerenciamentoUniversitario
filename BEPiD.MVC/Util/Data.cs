using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.Util
{
    public static class Data
    {
        public static String formataDataMMDDYYYY(String data)
        {
            String dataTotal = data;

            String dia = dataTotal.Substring(0, 2);
            String mes = dataTotal.Substring(3, 2);
            String ano = dataTotal.Substring(6, 4);

            return mes + "-" + ano + "-" + dia;
        }

        public static String formataDataRetornoFormulario(String data)
        {
            if (!String.IsNullOrEmpty(data))
            {
                String dia, mes, ano;
                String dataTotal = data;
                DateTime dataAtual = Convert.ToDateTime(data);

                dia = dataAtual.Day.ToString();
                mes = dataAtual.Month.ToString();
                ano = dataAtual.Year.ToString();

                if (dia.Length == 1)
                    dia = "0" + dia;

                if (mes.Length == 1)
                    mes = "0" + mes;

                return dia + "/" + mes + "/" + ano;
            }
            else
                return "";
        }

        public static String formataDataDDMMYYYY(String data)
        {
            String dataTotal = data;

            String dia = dataTotal.Substring(8, 2);
            String mes = dataTotal.Substring(5, 2);
            String ano = dataTotal.Substring(0, 4);

            return dia + "/" + mes + "/" + ano;
        }
    }
}
