using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, p, areat;


            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            p = A + B + C;

            areat = ((A + B) * C) / 2; 

            if (A>Math.Abs(B-C) && A<B+C && B > Math.Abs(A - C) && B < A + C && C > Math.Abs(A - B) && C < A + B)
            {
                Console.WriteLine("Perimetro = " + p.ToString("F1", CultureInfo.InvariantCulture));
            }

            else {
                Console.WriteLine("Area = " + areat.ToString("F1", CultureInfo.InvariantCulture));
                    }
           
        }

        }
    }