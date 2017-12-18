using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangBoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int i = 0;

            while (i++ < 100)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("PangBoom");
                    }
                    else
                    {
                        Console.WriteLine("Pang");
                    }
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Boom");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
