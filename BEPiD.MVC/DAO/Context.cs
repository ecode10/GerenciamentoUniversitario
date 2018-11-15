using Bancoob.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEPiD.Business.DAO
{
    internal class Context
    {
        public IDTec database;

        public Context()
        {
            if (database == null)
                database = DTecDefination.GetHelper();
        }
    }
}
