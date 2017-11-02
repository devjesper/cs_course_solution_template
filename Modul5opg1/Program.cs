using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5opg1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(double radius)
        {
            return  Math.Pow(radius,2) * System.Math.PI;
        }

        static double BeregnMoms(double beløb, double pct = 0.25)
        {
            return beløb * pct;
        }

        static  double gennemsnit(int[]månedsløn)
        {
            return månedsløn.Average();
        }
    }
}
