using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int tempo, velocidadeMedia;
        double distanciaPercorrida, Litros;

        tempo = int.Parse(Console.ReadLine());
        velocidadeMedia = int.Parse(Console.ReadLine());

        distanciaPercorrida = tempo * velocidadeMedia;

        Litros = distanciaPercorrida / 12;

        Console.WriteLine(Litros.ToString("F3"));



    }

}