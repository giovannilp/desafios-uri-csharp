using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, n, soma, i, j;
            string[] entrada = Console.ReadLine().Split(' ');

            a = int.Parse(entrada[0]); 
            n = int.Parse(entrada[1]); 

            i = 1; 
            while (n <= 0) 
            {
                i = i + 1; 
                n = int.Parse(entrada[i]); 
                                          
                                          
            }

            soma = 0; 
            for (j = 0; j < n; j++) 
                                    
            {
                soma = soma + a + j; 
            }

            Console.WriteLine(soma); 

            Console.ReadLine();
        }

    }
}