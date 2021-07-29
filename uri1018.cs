using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor, nota1, nota2, nota5, nota10, nota20, nota50, nota100;

            valor = int.Parse(Console.ReadLine());

            nota100 = valor / 100;
            nota50 = (valor % 100) / 50;
            nota20 = ((valor % 100) % 50) / 20;
            nota10 = (((valor % 100) % 50) % 20) / 10;
            nota5 = ((((valor % 100) % 50) % 20) % 10) / 5;
            nota2 = (((((valor % 100) % 50) % 20) % 10) % 5) / 2;
            nota1 = ((((((valor % 100) % 50) % 20) % 10) % 5) % 2) ;

            Console.WriteLine(valor); 
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");

        }

    }
}
