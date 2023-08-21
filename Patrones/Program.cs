using System;

namespace Patrones
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDeDatos oBD = Creator.GetBD(Creator.MongoDB);
            Console.WriteLine(oBD.GetConnString());
        }
    }
}

