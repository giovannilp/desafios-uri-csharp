using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double SALARY, x;
        int NUMBER, HOURS;


        
        NUMBER = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        HOURS = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        SALARY = x * HOURS;

        Console.WriteLine("NUMBER = " + NUMBER);
        Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2"));


    }

}