using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, d, e, ap, bp, cp, dp, ep, ai, bi, ci, di, ei, apos,bpos,cpos,dpos,epos, aneg, bneg,cneg,dneg,eneg;



            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            if (a % 2.0 == 0)
            {
                ap = 1;
                ai = 0;
                }
           
            else {  ap = 0; ai = 1; }


            if (b % 2.0 == 0)
            {
                bp = 1;
                bi = 0;
            }
            else { bp = 0; bi = 1; }


            if (c % 2.0 == 0)
            {
                cp = 1;
                ci = 0;
            }
            else {  cp = 0; ci = 1; }


            if (d % 2.0 == 0)
            {
                dp = 1;
                di = 0;
            }
            else { dp = 0; di = 1; }


            if (e % 2.0 == 0)
            {
                ep = 1;
                ei = 0;
            }
            else {  ep = 0; ei = 1; }


            if (a > 0 && a!= 0)
            {
                apos = 1;
                aneg = 0;
            }
            else { apos = 0; aneg = 1; }

            if (b > 0 && b != 0)
            {
                bpos = 1;
                bneg = 0;
            }
            else { bpos = 0; bneg = 1; }

            if (c > 0 && c != 0)
            {
                cpos = 1;
                cneg = 0;
            }
            else { cpos = 0; cneg = 1; }

            if (d > 0 && d != 0)
            {
                dpos = 1;
                dneg = 0;
            }
            else { dpos = 0; dneg = 1; }

            if (e > 0 && e != 0)
            {
                epos = 1;
                eneg = 0;
            }
            else { epos = 0; eneg = 1; }

            if (a == 0)
            {
                apos = 0;
                aneg = 0;
            }

            if (b == 0)
            {
                bpos = 0;
                bneg = 0;
            }

            if (c == 0)
            {
                cpos = 0;
                cneg = 0;
            }

            if (d == 0)
            {
                dpos = 0;
                dneg = 0;
            }

            if (e == 0)
            {
                epos = 0;
                eneg = 0;
            }



            Console.WriteLine(ap + bp + cp + dp + ep + " valor(es) par(es)"); //PARES//
            Console.WriteLine(ai + bi + ci + di + ei + " valor(es) impar(es)"); //IMPARES//
            Console.WriteLine(apos + bpos + cpos + dpos + epos + " valor(es) positivo(s)"); //POSITIVOS//
            Console.WriteLine(aneg + bneg + cneg + dneg + eneg + " valor(es) negativo(s)"); //NEGATIVOS//






        }
    }
}
