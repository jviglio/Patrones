using System;

namespace FactoryMethod2
{
    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
