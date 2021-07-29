using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, maior, pos;

            maior = 0;
            pos = 0;


            for (int i = 1; i <= 100; i++)
            {
              N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (N > maior)
                {
                    maior = N;
                    pos = i;
                }

            }

            Console.WriteLine(maior);
            Console.WriteLine(pos);

        }
    }
}