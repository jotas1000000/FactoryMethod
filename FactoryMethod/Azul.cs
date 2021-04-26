using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Azul : IBoligrafo
    {
        public void rayar()
        {
            Console.WriteLine("Rayando Azul");
        }
    }
}
