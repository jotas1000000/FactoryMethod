using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Rojo : IBoligrafo
    {
        public void rayar()
        {
            Console.WriteLine("Rayando Rojo");
        }
    }
}
