using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0], CultureInfo.InvariantCulture);
            y = int.Parse(vet[1], CultureInfo.InvariantCulture);

            while (x!=0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");

                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }

                else { Console.WriteLine(" "); }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0], CultureInfo.InvariantCulture);
                y = int.Parse(vet[1], CultureInfo.InvariantCulture);
            }




        }
    }
}