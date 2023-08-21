using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    class MongoDB : BaseDeDatos
    {
        public override string GetConnString()
        {
            return "Mongo DB Connection String";
        }
    }
}
