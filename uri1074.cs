using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, x, y;

            N = int.Parse(Console.ReadLine());

            y = 0;
 

            for (int i=1 ; i<=N; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0 && x!=0)
                {
                    Console.Write("EVEN ");
                }

                if (x % 2 != 0)
                {
                    Console.Write("ODD ");
                }

                if (x > 0)
                {
                    Console.WriteLine("POSITIVE");
                }

                if (x < 0)
                {
                    Console.WriteLine("NEGATIVE");
                }

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }


            }

 





        }
    }
}