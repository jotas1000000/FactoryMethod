using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coloresDelPedido = { "Azul","Rojo","Negro","Negro","Azul" };
            List<string> pedidos = new List<string>(coloresDelPedido); 

            BoligrafoFactory fabrica = new ConcreteBoligrafoFactory();

            List<IBoligrafo> boligrafosDelPedido = new List<IBoligrafo>();
            foreach(string color in pedidos)
            {
                boligrafosDelPedido.Add(fabrica.crearBoligrafo(color));
            }
            
            //Verificando pedido
            foreach(IBoligrafo boligrafo in boligrafosDelPedido)
            {
                boligrafo.rayar();
            }

        }
    }
}
