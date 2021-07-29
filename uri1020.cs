using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor, anos, meses, dias;

            valor = int.Parse(Console.ReadLine());

            anos = valor / 365;
            meses = (valor % 365) / 30;
            dias = ((valor % 365) % 30);


             
            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");


        }

    }
}
