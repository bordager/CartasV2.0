using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta_V2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            ClsCartaEspañola carta;
            carta = new ClsCartaEspañola();


            

            for (int i = 1; i < 49; i++)
            {
            carta = carta.GetCartaEspañola();
            Console.WriteLine(carta.Numero + carta.Palo);
            Console.ReadKey();
            }

            Console.ReadKey();




        }


    }
}
