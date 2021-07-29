using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int nomediaI, horaI, minutoI, segundoI, nomediaF, horaF, minutoF, segundoF;
            int somadia1, somadia2, segundoT, horaR, minutoR, segundoR, diaR;
            string di1,di2;
            string[] vet;                    

            vet = Console.ReadLine().Split(' ');

            di1 = vet[0];
            nomediaI = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(':');
            horaI = int.Parse(vet[0]);
            minutoI = int.Parse(vet[1]);
            segundoI = int.Parse(vet[2]);

            vet = Console.ReadLine().Split(' ');

            di2 = vet[0];
            nomediaF = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(':');
            horaF = int.Parse(vet[0]);
            minutoF = int.Parse(vet[1]);
            segundoF = int.Parse(vet[2]);

            somadia1 = segundoI + minutoI * 60 + horaI * 60 * 60 + nomediaI * 24 * 60 * 60;
            somadia2 = segundoF + minutoF * 60 + horaF * 60 * 60 + nomediaF * 24 * 60 * 60;
            segundoT = somadia2 - somadia1;

            diaR = segundoT / (24 * 60 * 60);
            horaR = (segundoT - diaR * 24 * 60 * 60) / (60 * 60);
            minutoR = (segundoT - horaR * 60 * 60 - diaR * 24 * 60 * 60) / 60;
            segundoR = segundoT - minutoR * 60 - horaR * 60 * 60 - diaR * 24 * 60 * 60;

            Console.WriteLine(diaR +" dia(s)");
            Console.WriteLine(horaR +" hora(s)");
            Console.WriteLine(minutoR +" minuto(s)");
            Console.WriteLine(segundoR + " segundo(s)");






        }

    }
}