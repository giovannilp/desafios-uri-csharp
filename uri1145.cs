using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, contador, contador2;
            

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0], CultureInfo.InvariantCulture);
            y = int.Parse(vet[1], CultureInfo.InvariantCulture);

            contador = 1;
            contador2 = 1;
           

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);


                if (contador == x)
                {
                    Console.WriteLine();
                    
                }

                else
                {
                    Console.Write(" ");
                }
                   

                if (contador == x)
                {
                    contador = 0;
                }

                contador += 1;
                contador2 += 1;

                
            }

           

        }
    }
}