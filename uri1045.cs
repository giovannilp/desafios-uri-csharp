using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y, z, A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (x>=y && x >= z)
            {
                A = x;
                B = y;
                C = z;
            }

            else if (y>=x && y >= z)
            {
                A = y;
                B = x;
                C = z;
            }

            else 
            {
                A = z;
                B = x;
                C = y;
            }

            if (A >= (B + C))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }

            else if ( A*A == Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }

            else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }

            else if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }





            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }

            else if (A == B || B == C || A == C) {
                
                Console.WriteLine("TRIANGULO ISOSCELES"); }

        }

    }
    }