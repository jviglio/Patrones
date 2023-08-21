using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    class SqlDB : BaseDeDatos
    {
        public override string GetConnString()
        {
            return "SQL Connection String";
        }
    }
}
