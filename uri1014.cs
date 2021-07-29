using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int x;
        double y, Kml;

        x = int.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());

        Kml = x / y;

        Console.WriteLine(Kml.ToString("F3") + " km/l");

    }

}
