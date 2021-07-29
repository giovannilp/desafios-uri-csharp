using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, x, y, z;

            N = int.Parse(Console.ReadLine());

            y = 0;
            z = 0;

            for (int i=1 ; i<=N; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    y += 1;
                }

                else { z += 1; }
            }

            Console.WriteLine(y + " in");
            Console.WriteLine(z + " out");





        }
    }
}