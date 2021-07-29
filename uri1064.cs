using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, d, e, f, a1, b1, c1, d1, e1, f1, media;
           
           

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

            if (a > 0)
            {
                a1 = 1;
            }

            else { a1 = 0; a = 0; }

             if (b > 0)
            {
                b1 = 1;
            }
            else { b1 = 0; b = 0; }

            if (c > 0)
            {
                c1 = 1;
            }
            else { c1 = 0; c = 0; }

            if (d > 0)
            {
                d1 = 1;
            }
            else { d1 = 0; d = 0; }

            if (e > 0)
            {
                e1 = 1;
            }
            else { e1 = 0; e = 0; }

            if (f > 0)
            {
                f1 = 1;
            }
            else  { f1 = 0; f = 0; }

            media = (a + b + c + d + e + f) / (a1 + b1 + c1 + d1 + e1 + f1);

                Console.WriteLine(a1 + b1 + c1 + d1 + e1 + f1 + " valores positivos");
                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));





        }
    }
}
