using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int A, B, C, D, CD, AB;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            B = int.Parse(vet[1], CultureInfo.InvariantCulture);
            C = int.Parse(vet[2], CultureInfo.InvariantCulture);
            D = int.Parse(vet[3], CultureInfo.InvariantCulture);

            CD = C + D;
            AB = A + B;

            if (B > C && D > A && CD > AB && C > 0 && D > 0 && A % 2 == 0) {
                Console.WriteLine("Valores aceitos");
                    }

            else { Console.WriteLine("Valores nao aceitos"); }



        }
    }
}