using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int hI, hF, hT, mI, mF, mT;

            string[] vet = Console.ReadLine().Split(' ');
            hI = int.Parse(vet[0], CultureInfo.InvariantCulture);
            mI = int.Parse(vet[1], CultureInfo.InvariantCulture);
            hF = int.Parse(vet[2], CultureInfo.InvariantCulture);
            mF = int.Parse(vet[3], CultureInfo.InvariantCulture);

            hT = hF - hI;
            mT = mF - mI;

            if (hT == 0 && mT > 0 ) 
            {
                hT += 0;
                mT += 0;

            }

            if (hT == 0 && mT < 0)
            {
                hT -= 1;
                mT += 60;

            }

            if (hT < 0)
            {
                hT += 24;
            }

            if (mT< 0)
            {
                mT += 60;
                hT -= 1;
            }


            if ( hT == 0 && mT == 0)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");

            }

            else { Console.WriteLine("O JOGO DUROU " + hT + " HORA(S) E " + mT + " MINUTO(S)"); }

        }

    }
    }