using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tärningssimulatorn
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();  //skapar slumpade tal på tärningarna 
            int sum = 0; //<räknar ut summan>
            int count = 0; //<för att fungera att loopa tillbaka till början>
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.Write("Hej och välkommen till tärningssimulatorn!");

                Console.Write("\nHur många tärningar vill du kasta? ");
                running = int.TryParse(Console.ReadLine(), out int inputThrow);

                while (!running)
                {
                    if (!running)
                    {
                        //<statement för felhantering vid annat än siffra>
                        Console.WriteLine("Fel inmatning. Försök med siffror");
                        running = int.TryParse(Console.ReadLine(), out inputThrow);
                    }
                }

                Console.Write("Hur många sidor ska tärningen ha? ");
                running = int.TryParse(Console.ReadLine(), out int inputSide);

                while (!running)
                {
                    if (!running)
                    {
                        //<statement för felhantering vid annat än siffra>
                        Console.WriteLine("Fel inmatning. Försök med siffror");
                        running = int.TryParse(Console.ReadLine(), out inputSide);
                    }
                }

                Console.Write("Hur många gånger vill du kasta? ");
                running = int.TryParse(Console.ReadLine(), out int inputHits);

                while (!running)
                {
                    if (!running)
                    {
                        //<statement för felhantering vid annat än siffra>
                        Console.WriteLine("Fel inmatning. Försök med siffror");
                        running = int.TryParse(Console.ReadLine(), out inputHits);
                    }
                }

                for (int i = 1; i <= inputHits; i++) // loopar per omgång
                {
                    int makeZero = 0;
                    Console.WriteLine("Omgång " + i); //skrivs ut rätt

                    for (int j = 0; j < inputThrow; j++) // loopar per tärning, från 0 för annars missas en tärning
                    {
                        int kast = rand.Next(1, inputSide + 1);
                        sum += kast; //måste ha för att räkna ihop summan
                        makeZero += kast; // för sammanlagt värde per omgång
                        Console.Write(kast + " "); //nu är allt på en bra rad
                    }
                    Console.WriteLine(" summa =  " + makeZero + "\n");
                }

                Console.WriteLine("Totala summan: " + sum); //Totala summan
                double divided = (double)sum / (double)inputHits;
                Console.WriteLine("Medelvärdet per omgång är: " + divided);

                Console.WriteLine("\nVill du spela igen?"); //fungerar bara med strängar

                while (count == 0)
                {
                    string yesOrNo = Console.ReadLine();

                    if (yesOrNo.ToLower() == "ja")
                    {
                        //<statement för att gå tillbaka till början av programmet>
                        break;
                    }

                    else if (yesOrNo.ToLower() == "nej")
                    {
                        //<statement för att avsluta>
                        running = false;
                        break;
                    }

                    else
                    {
                        //<statement för att hantera andra input än ja och nej>
                        Console.WriteLine("Fel val, försök igen med ja eller nej");
                    }
                }
            }
        }
    }
}
