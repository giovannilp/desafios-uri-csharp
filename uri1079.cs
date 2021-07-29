using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double N, a, b, c, soma, media;

            N = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            


            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                soma = a + b + c;
                media = ((a * 2) + (b * 3) + (c * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }





        }
    }
}