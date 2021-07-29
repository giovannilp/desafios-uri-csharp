using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            double q;

            N = int.Parse(Console.ReadLine());
         


            for (int i=1 ; i<=N; i++) {

                if (i % 2 == 0 && N>5 && N<2000){

                    q = Math.Pow(i, 2);

                    Console.WriteLine(i + "^2 = " + q);
                    }
                }


        }
    }
}