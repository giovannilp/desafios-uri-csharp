using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
       
        double area, n, raio, y;
        

        y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        n = 3.14159;
        raio = Math.Pow(y, 2);

        area = n * raio;


        Console.WriteLine("A="+ area.ToString("F4", CultureInfo.InvariantCulture)); 




    }

}
