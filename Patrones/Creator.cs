using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    public class Creator
    {
        public const int SqlDB = 1;
        public const int MongoDB = 2;

        public static BaseDeDatos GetBD(int Tipo)
        {
            switch (Tipo)
            {
                case SqlDB:
                    return new SqlDB();
                case MongoDB:
                    return new MongoDB();
                default:
                    return null;
            }
        }
    }
}
