using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, a, b, c, d, e, f;

            x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
            if (x % 2 == 0)
            {
                a = x + 1;
                b = a + 2;
                c = b + 2;
                d = c + 2;
                e = d + 2;
                f = e + 2;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f);
            }

            else if (x % 2 != 0)           
                {
                    a = x ;
                    b = a + 2;
                    c = b + 2;
                    d = c + 2;
                    e = d + 2;
                    f = e + 2;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f);
            }

           






        }
    }
}