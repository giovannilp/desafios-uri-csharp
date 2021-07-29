using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x,y,z;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0], CultureInfo.InvariantCulture);
            y = int.Parse(vet[1], CultureInfo.InvariantCulture);
            z = int.Parse(vet[2], CultureInfo.InvariantCulture);

            if (x<y && x<z)
            {
                Console.WriteLine(x);
            }

            else if (y<x && y<z)
            {
                Console.WriteLine(y);
            }

            else if (z<x && z<y)
            {
                Console.WriteLine(z);
            }



            if (x>y && x<z || x<y && x>z)
            {
                Console.WriteLine(x);
            }

            else if (y<x && y>z || y>x && y<z)
            {
                Console.WriteLine(y);
            }

            else if (z<x && z>y || z>x && z<y)
            {
                Console.WriteLine(z);
            }



            if (x>y && x>z)
            {
                Console.WriteLine(x);
            }

            else if (y>x && y>z)
            {
                Console.WriteLine(y);
            }

            else if (z>x && z>y)
            {
                Console.WriteLine(z);
            }




            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }

        }
    }
