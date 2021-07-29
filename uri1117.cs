using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, soma, media;
            int cont;


            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            cont = 0;

            while (cont !=2)
            {

                if (x > 0.0 && x <= 10.0)
                {
                    soma += x;
                    cont += 1;
                }

                else if (x < 0.0 || x > 10.0)
                {
                    Console.WriteLine("nota invalida");
                }


                if (cont == 2)
                {
                    media = (soma) / 2.0;
                    Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));                
                }


                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

        }
    }
}