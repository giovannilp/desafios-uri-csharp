using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string x, y, z;

            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            if (x == "vertebrado")
            {
                if (y == "ave")
                {
                    if (z == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }


                    else if (z == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }

                if (x == "vertebrado")
                {
                    if (y == "mamifero")
                    {
                        if (z == "onivoro")
                        {
                            Console.WriteLine("homem");
                        }


                        else if (z == "herbivoro")
                        {
                            Console.WriteLine("vaca");
                        }
                    }
                }
            }


            if (x == "invertebrado")
            {
                if (y == "inseto")
                {
                    if (z == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }


                    else if (z == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }

                if (x == "invertebrado")
                {
                    if (y == "anelideo")
                    {
                        if (z == "hematofago")
                        {
                            Console.WriteLine("sanguessuga");
                        }


                        else if (z == "onivoro")
                        {
                            Console.WriteLine("minhoca");
                        }
                    }
                }
            }










        }
    }
}