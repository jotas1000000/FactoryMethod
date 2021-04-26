using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Negro : IBoligrafo
    {
        public void rayar()
        {
            Console.WriteLine("Rayando Negro");
        }
    }
}
