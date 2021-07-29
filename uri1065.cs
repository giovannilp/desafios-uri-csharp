using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, d, e;



            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




            if (a % 2.0 == 0)
            {
                a = 1; }
           
            else {  a = 0; }



            if (b % 2.0 == 0)
            {
                b = 1;
            }
            else { b = 0; }

            if (c % 2.0 == 0)
            {
                c = 1;
            }
            else {  c = 0; }

            if (d % 2.0 == 0)
            {
                d = 1;
            }
            else { d = 0; }

            if (e % 2.0 == 0)
            {
                e = 1;
            }
            else {  e = 0; }


         
            Console.WriteLine(a + b + c + d + e + " valores pares");
            





        }
    }
}