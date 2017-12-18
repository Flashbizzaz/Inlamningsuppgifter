using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HängaGubbe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var försök = 0; //Antal spel
            bool vunnit = false;//För att kunna komma ur Whileloop.
            string allaMissar = ""; //För att spara alla missar
            string rättSvar = "";


            Console.WriteLine("Den som ska spela måste titta bort nu! ");
            Console.Write("Skriv in ett ord: ");
            rättSvar = Console.ReadLine().ToUpper(); //Facit för spelet att jämföra med


            char[] rättSvariArray = rättSvar.ToCharArray(); //Stoppar in svaret i en charArray
            char[] spelarInfo = new char[rättSvar.Length]; // gissningar ska sparas och ersättas när det är rätt

            for (int i = 0; i < spelarInfo.Length; i++)
            {
                spelarInfo[i] = '_';
            }

            Console.WriteLine("Enter för att fortsätta...");
            Console.ReadLine();
            Console.Clear();

            //Gissningarna
            while (försök < 6 && vunnit == false)
            {
                string input = " ";
                försök++;
                string testaGissnigar;

                //Information till spelare
                for (int i = 0; i < spelarInfo.Length; i++)
                {
                    Console.Write(spelarInfo[i]);
                }
                Console.WriteLine("\nFörsök: {0}/6", försök);


                if (allaMissar.Length > 0) //Kommer upp när man börjar missar
                {
                    Console.WriteLine("Missar: {0}", allaMissar);
                }

                if (försök==6)
                {
                    Console.WriteLine("ETT FÖRSÖK KVAR");
                }

                Console.WriteLine("\nGissa en bokstav eller hela ord");
                input = Console.ReadLine().ToUpper();   //För att testa hela ordet


                if (input == rättSvar)  //Testar om ordet är korrekt i sin helhet
                {
                    Console.WriteLine("Du har hittat ordet\n " +
                        "Gissat ord är {0}" +
                        "\nDu gissade på {1} försök", rättSvar, försök);
                    Console.ReadLine();
                    vunnit = true;
                }

                else if (input.Length == 1)  //Testar nybokstav
                {
                    var inputIChars = char.Parse(input); //För att testa bokstaven om gissaren har testat en bokstav.

                    bool redanGissat = allaMissar.Contains(input); 
                    bool rättGissat = false;
                    bool felGissning = false;

                    for (int i = 0; i < rättSvariArray.Length; i++)
                    {
                        if (inputIChars == spelarInfo[i]) //Kontrollera om det är redangissning
                        {
                            redanGissat = true;
                        }

                        else if (rättSvariArray[i] == inputIChars) //kolla om det är rättgissning
                        {
                            spelarInfo[i] = inputIChars;
                            rättGissat = true;
                        }

                        else if (rättSvariArray[i] != inputIChars) //Kolla om det är felgissning
                        {
                            felGissning = true;
                        }

                        testaGissnigar = new string(spelarInfo); //För att testa om bokstäverna blivit mitt ord
                        if (testaGissnigar == rättSvar)
                        {
                            vunnit = true;
                        }
                    }

                    
                    if (redanGissat==false && rättGissat == false) //Kollar så att det är en ny fel gissning
                    {
                        allaMissar += input;
                    }

                    if (redanGissat == true)
                    {
                        försök--;
                        Console.WriteLine("Du har redan gissat denna bokstav" +
                            "\nEnter för att fortsätta...");
                        Console.ReadLine();
                    }

                    else if (rättGissat == true)
                    {
                        Console.WriteLine("Bra gissat, {0} är rätt" +
                            "\nEnter för att fortsätta...", input);
                        försök--;
                        Console.ReadLine();
                    }

                    else if (felGissning == true)
                    {
                        Console.WriteLine("{0} är fel" +
                            "\nEnter för att fortsätta...", input);
                        Console.ReadLine();
                    }
                }

                else  //borde hantera alla felskrivningar. eller?
                {
                    Console.WriteLine("FEL!!!\nDu har {0} försök kvar", 6 - försök);
                    Console.ReadLine();
                }

                Console.Clear();

            }

            //Avslutningsmeddelande

            if (försök < 6)
            {
                Console.WriteLine("GRATTIS!!! DU ÄR EN VINNARE!!!! \nDu klarade det med {0} försök kvar", 6-försök);
            }
            else
            {
                Console.WriteLine("Du förlorade\nRätt svar är : {0}", rättSvar);
            }

        }
    }
}



