using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, min, max, soma;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0], CultureInfo.InvariantCulture);
            y = int.Parse(vet[1], CultureInfo.InvariantCulture);

            while (x!=0 && x >0 && y>0 && y!= 0)
            {

                if (x < y)
                {
                    min = x;
                    max = y;
                }

                else
                {
                    min = y;
                    max = x;
                }

                soma = 0;

                for (int ii = min; ii <= max; ii++)
                {

                    Console.Write(ii+" ");
                    soma = soma + ii;
                }

                Console.WriteLine("Sum="+soma);

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0], CultureInfo.InvariantCulture);
                y = int.Parse(vet[1], CultureInfo.InvariantCulture);
            }

        }
    }
}