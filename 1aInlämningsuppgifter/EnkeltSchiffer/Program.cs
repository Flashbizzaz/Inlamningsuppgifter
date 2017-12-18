using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> decryptaOrdet = new List<char>();//Sparar ordet
            List<char> fångaOrdet = new List<char>();//spara ordet
            bool looping = true;

            while (looping)
            {
                Console.Write("Skriv din hemliga text: ");
                string secretText = Console.ReadLine().ToUpper();

                Console.WriteLine();

                Console.Write("Skriv i vilket tal som ska vara nyckeln (mellan 10 och -10): ");
                int key = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (key >= (-10) && key <= 10)
                {
                    List<int> list = new List<int>();
                    int counter = 0;

                    byte[] asciiKoden = Encoding.ASCII.GetBytes(secretText); //gör om bokstäverna i hemligatexten till byte och sätter dem i en array...
                    foreach (Byte letter in asciiKoden) // Loopar igenom listan
                    {
                        if (letter >= 65 || letter >= 90)//Checkar ifall ascii är mellan A-Z...
                        {
                            int crypted = letter;
                            crypted += key;       //Använder nyckeln för att kryptera

                            if (crypted - 65 < 0) //65 i acii är A
                            {
                                crypted -= 65;
                                crypted = 91 + crypted;
                            }

                            else if (crypted - 90 > 0) //90 i aci är Z
                            {
                                crypted -= 90;
                                crypted = 64 + crypted;
                            }

                            list.Add(crypted); //lägger till funktionen crypted till listan
                            counter++;
                        }

                        else
                        {
                            int a = letter;
                            list.Remove(a); //tar bort andra tecken än a-z i listan (tar också bort space)
                        }
                    }

                    Console.Write("Den krypterade koden är: ");
                    List<string> cryptedList = new List<string>();

                    for (int i = 0; i < counter; i++)
                    {
                        int kryptkod = list[i];
                        char character = (char)kryptkod;
                        cryptedList.Add(character.ToString());
                        Console.Write(cryptedList[i]);

                    }


                    Console.Write("\n\nSkriv in din krypterade kod: ");
                    string cryptToRegular = Console.ReadLine().ToUpper();

                    Console.Write("\nLås upp krypteringen med din nyckel: ");
                    int key2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (key2 >= (-10) && key <= 10) //Tvärt om, dekrypteringsfunktion
                    {

                        byte[] ascii2 = Encoding.ASCII.GetBytes(cryptToRegular);
                        foreach (Byte b in ascii2)
                        {
                            if (b >= 65 || b >= 90)//kollar ifall ascii är mellan A-Z...
                            {
                                int aciiCrypt = b;         //gör om char till ascii...
                                aciiCrypt += key2;       //använder nyckeln för att kryptera

                                if (aciiCrypt - 65 < 0)
                                {
                                    aciiCrypt -= 65;
                                    aciiCrypt = 91 + aciiCrypt;
                                }
                                else if (aciiCrypt - 90 > 0)
                                {
                                    aciiCrypt -= 90;
                                    aciiCrypt = 64 + aciiCrypt;
                                }
                                decryptaOrdet.Add((char)aciiCrypt);
                            }
                        }

                        for (int i = 0; i < counter; i++)
                        {
                            int result = decryptaOrdet[i];
                            char character = (char)result;
                            fångaOrdet.Add(character);
                            Console.Write(fångaOrdet[i]);
                        }
                        Console.ReadLine();
                        looping = false;
                    }
                }

                else
                {
                    Console.WriteLine("Felaktig inmatning! Tryck enter för att göra ett nytt försök!");
                    Console.ReadLine();
                }
            }

        }
    }
}