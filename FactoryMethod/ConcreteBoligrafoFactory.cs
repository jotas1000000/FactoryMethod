using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteBoligrafoFactory : BoligrafoFactory
    {
        public override IBoligrafo crearBoligrafo(string tipoBoligrafo)
        {
            switch (tipoBoligrafo)
            {
                case "Rojo":
                    return new Rojo();
                case "Azul":
                    return new Azul();
                case "Negro":
                    return new Negro();
                default:
                    return new Rojo();
            }
        }
    }
}
