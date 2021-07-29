using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y;

            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x <= 2000.00)
            {
                Console.WriteLine("Isento");
            }

            else if (x > 2000.01 && x <= 3000.00)
            {

                x -= 2000.00;
                x *= 0.08; 
             
                Console.WriteLine("R$ " + x.ToString("F2",CultureInfo.InvariantCulture));
            }

            else if (x > 3000.01 && x <= 4500.00)
            {

                x -= 3000.00;
                x = (x*0.18) + (1000*0.08);

                Console.WriteLine("R$ " + x.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (x > 4500.00)
            {

                x -= 4500;
                x = (x * 0.28) + (1500 * 0.18) + (1000 * 0.08);

                Console.WriteLine("R$ " + x.ToString("F2", CultureInfo.InvariantCulture));


            }


        }
    }
}