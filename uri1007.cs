using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double A, B, C, D, DIFERENCA;
        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        DIFERENCA = (A * B - C * D);

        Console.WriteLine("DIFERENCA = " + DIFERENCA);


    }

}