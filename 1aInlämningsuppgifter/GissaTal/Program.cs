using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int slumpTal = 0;
            bool rättsvar = false;
            int omgång = 0;
            Random rnd = new Random(); //instanserar randomklassen


            while (rättsvar == false)
            {
                if (omgång == 0)
                {
                    int slump = rnd.Next(1, 101);
                    slumpTal = slump; //sparar ner det slumpade numret i int slumptal för användning för resten av rundan
                    Console.WriteLine("Gissa ett tal mellan 1-100");
                    omgång++;
                } //ökar omgång så att det står omgång 1 för första gissningen

                Console.Write("Gissning " + omgång + ": ");
                string gissString = (Console.ReadLine()); //ber användaren att gissa tal mellan 1-100

                if (!int.TryParse(gissString, out int gissning)) //skapar en bool där man ser ifall det går att Parse:a gissString(användarens gissning) och skickar ut en int
                {
                    Console.WriteLine("Du kan bara skriva tal med siffror. Försök igen!");
                    continue; //skippar resten av while loopen för att be om en ny gissning
                }
                if (gissning > slumpTal)
                {
                    Console.WriteLine("Talet är mindre");
                    omgång++; //omgång ökas för varje giltig gissning
                }
                if (gissning < slumpTal)
                {
                    Console.WriteLine("Talet är större");
                    omgång++;
                }
                if (gissning == slumpTal) //kollar om användarens gissning stämmer överens med det slumpade talet (slumpTal)
                {
                    Console.WriteLine("Rätt! Du gissade rätt på " + omgång + " försök.");
                    while (omgång > 0)
                    {
                        Console.WriteLine("Vill du spela igen?(Ja/Nej)");
                        string jaNej = (Console.ReadLine()).ToLower(); //användaren skriver in ja/nej (icke case sensitive) 

                        if (jaNej == "ja")
                        {
                            omgång = 0; //omgång ställs till 0 så att programmet hoppar in i att be användaren gissa ett tal mellan 1-100, men även för att slumpa fram ett nytt tal
                        }
                        if (jaNej == "nej")
                        {
                            rättsvar = true; //bryter ut ur första while loopen
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Tack för den här gången!");
            Console.ReadLine();
        }
    }
}
