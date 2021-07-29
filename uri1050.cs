using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;

            x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == 61)
            {
                Console.WriteLine("Brasilia");
            }

            else if (x == 71)
            {
                Console.WriteLine("Salvador");
            }

            else if (x == 11)
            {
                Console.WriteLine("Sao Paulo");
            }

            else if (x == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }

            else if (x == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }

            else if (x == 19)
            {
                Console.WriteLine("Campinas");
            }

            else if (x == 27)
            {
                Console.WriteLine("Vitoria");
            }

            else if (x == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }

            else { Console.WriteLine("DDD nao cadastrado"); }

        }
    }
}
