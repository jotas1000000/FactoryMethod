using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class BoligrafoFactory
    {
        public abstract IBoligrafo crearBoligrafo(string tipoBoligrafo);
    }
}
