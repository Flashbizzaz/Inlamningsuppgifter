using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HängaGubbeFörsök2
{
    class Program
    {
        static void Main(string[] args)
        {

            var försök = 6; //Antal spel
            bool vunnit = false;

            Console.WriteLine("Den som ska spela måste titta bort nu! ");
            Console.Write("Skriv in ett ord: ");
            var rättSvar = Console.ReadLine().ToUpper(); //Spelord
            var rättSvarArray = rättSvar.ToArray();
            Console.Clear();

            string[] gissadeBokstäver = new string[rättSvar.Length]; // gissningar ska sparas och ersättas när det är rätt


            for (int i = 0; i < rättSvar.Length; i++) //Gissningarna får * för varje bokstav
            {
                gissadeBokstäver[i] = "*";
            }


            while (vunnit == false && försök > 0)
            {
                försök--;

                //Information till spelare
                for (int i = 0; i < gissadeBokstäver.Length; i++)
                {
                    Console.Write(gissadeBokstäver[i]);
                }

                Console.WriteLine("\nFörsök nr: {0}", 6-försök);

                Console.WriteLine("Gissa bokstav eller ord");
                var input = Console.ReadLine().ToUpper();
                var inputArray = input.ToArray();



                for (int i = 0; i < rättSvar.Length; i++)
                {

                    //Ska kolla om ord och/eller bokstav stämmer, är det rätt bokstav ersätt i gissade bokstäver
                   if (input.Length == 1 && inputArray[i]==rättSvarArray[i])
                    {
                        Console.WriteLine("Rätt bokstav");
                        gissadeBokstäver[i] = inputArray[];
                        Console.ReadLine();

                        if (gissadeBokstäver[i].ToString() == rättSvar)
                        {
                            vunnit = true;
                        }

                    }

                    else if (true)
                    {

                    }

                }
            }






        }
    }
}
