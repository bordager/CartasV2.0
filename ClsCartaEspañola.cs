using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta_V2._0
{
    public class ClsCartaEspañola : ClsAbsCartasDeJuegos
    {

        /*       public ClsCartaEspañola(int Numero)
                {
                    this.Numero = Numero;

                }
                public ClsCartaEspañola(String Palo)
                {
                    this.Palo = Palo;
                }*/
        List<ClsCartaEspañola> descarte = new List<ClsCartaEspañola>();



        public ClsCartaEspañola GetCartaEspañola()
        {
            ClsCartaEspañola carta;
            carta = new ClsCartaEspañola();
            bool alreadyexist = true;
            do
            {
                carta.Numero = carta.getnumerocartaespañola().ToString();
                carta.Palo = carta.getpalocartaespañola();
                Console.WriteLine(alreadyexist);
                alreadyexist = descarte.Contains(carta);
                Console.WriteLine(alreadyexist);

            } while (alreadyexist == true);

            descarte.Add(new ClsCartaEspañola() { Numero = carta.Numero, Palo = carta.Palo });
            
            foreach (ClsCartaEspañola dato in descarte )
            {
                Console.WriteLine(dato);
            }

            return carta;
        }

        private int getnumerocartaespañola()
        {
            var random = new Random();
            var value = random.Next(1, 12);
            int numero = 0;

            value = random.Next(1, 12);
            numero = value;

            return numero;

        }
        private string getpalocartaespañola()
        {
            var random = new Random();
            var value = random.Next(1, 4);
            string palo = "";

            if (value == 1)
            {
                palo = "Basto";
            }
            if (value == 2)
            {
                palo = "Oro";
            }
            if (value == 3)
            {
                palo = "Copa";
            }
            if (value == 4)
            {
                palo = "Espadas";
            }

            return palo;

        }


    }

    
}
