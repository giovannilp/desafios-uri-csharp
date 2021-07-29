using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;

            x = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            while (x != 2002)
            {
                Console.WriteLine("Senha Invalida");
                x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (x == 2002)
                {
                    Console.WriteLine("Acesso Permitido");

                }
               

            


            }
    }
}