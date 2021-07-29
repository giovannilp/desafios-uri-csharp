using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int hI, hF, hT;

            string[] vet = Console.ReadLine().Split(' ');
            hI = int.Parse(vet[0], CultureInfo.InvariantCulture);
            hF = int.Parse(vet[1], CultureInfo.InvariantCulture);

            if (hF-hI < 0)
            {
                hT = 24 + (hF - hI);
                Console.WriteLine("O JOGO DUROU " + hT + " HORA(S)");
            }

            else if (hF == hI)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }

            else if (hF - hI > 0)
            {
                hT = hF - hI;
                Console.WriteLine("O JOGO DUROU " + hT + " HORA(S)");

            }


        }

    }
    }