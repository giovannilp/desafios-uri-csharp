using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int inicio, x, y, min, max, soma;


            inicio = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

            for (int i = 1; i <= inicio ; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0], CultureInfo.InvariantCulture);
                y = int.Parse(vet[1], CultureInfo.InvariantCulture);
                

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

                for (int ii = min + 1; ii < max; ii++)
                    {
                        if (ii % 2 != 0)
                        {
                            soma = soma + ii;
                        }

                        
                    }

                Console.WriteLine(soma);




            }

            

        }
    }
}
