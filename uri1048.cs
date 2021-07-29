using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario, reajuste, salarioF;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (salario >= 0 && salario <= 400.00)
            {
                reajuste = salario * (0.15);
                salarioF = salario + (salario * 0.15);
                

                Console.WriteLine("Novo salario: " + salarioF.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }

            else if (salario >= 400.01 && salario <= 800.00)
            {
                reajuste = salario * (0.12);
                salario = salario + (salario * 0.12);
                

                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }


              else  if (salario >= 800.01 && salario <= 1200.00)
            {
                
                salarioF = salario + (salario * 0.1);
                reajuste = salario * (0.10);

                Console.WriteLine("Novo salario: " + salarioF.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }


                else if (salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = salario * (0.07);
                salario = salario + (salario * 0.07);
                

                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }


             else if (salario > 2000.00)
            {
                reajuste = salario * (0.04);
                salario = salario + (salario * 0.04);
                

                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }





        }

    }
    }
