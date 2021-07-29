using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x,q;
            double total;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0], CultureInfo.InvariantCulture);
            q = int.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 1)
            {
                total = q * 4.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (x == 2)
            {
                total = q * 4.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (x == 3)
            {
                total = q * 5.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (x == 4)
            {
                total = q * 2.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            else
            {
                total = q * 1.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}