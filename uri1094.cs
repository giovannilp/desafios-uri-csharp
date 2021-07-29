using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            string t;
            double pc, pr, ps, n, coelho, rato, sapo, total;
            

            N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            coelho = 0;
            rato = 0;
            sapo = 0;

            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                n = int.Parse(vet[0], CultureInfo.InvariantCulture);
                t = vet[1];

                if (t == "C")
                {
                    coelho += n;
                }

                if (t == "R")
                {
                    rato += n;
                }

                if (t == "S")
                {
                    sapo += n;
                }

            }

            total = coelho + sapo + rato;
            pc = (coelho/total)*100;
            pr = (rato / total) * 100;
            ps = (sapo / total) * 100;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + pc.ToString("F2",CultureInfo.InvariantCulture)+ " %");
            Console.WriteLine("Percentual de ratos: " + pr.ToString("F2", CultureInfo.InvariantCulture) +" %");
            Console.WriteLine("Percentual de sapos: " + ps.ToString("F2", CultureInfo.InvariantCulture) + " %");



        }
    }
}