using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //modul5_1();

            //mdul5_2();

            module5_3();

            Console.ReadLine();

        }

//************************************************************************************
        public static void modul5_1()
        {
            int res = LaegSammen(5, 2);
            Console.WriteLine(res);
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            udskriv();
            udskriv("Dette er en test");

            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);

            double res4 = BeregnMoms(100.35, 0.25);
            Console.WriteLine(res4);

            int[] løn = { 10000, 5000, 30000 };

            double gns = gennemsnit(løn);

            Console.WriteLine(gns);

            Console.ReadLine();
        }       

        public static int LaegSammen(int a, int b)
        {
            return a+b;
        }

        public static double BeregnAreal( int radius)
        {
            return 2 * radius * System.Math.PI;
        }

        public static double BeregnMoms(double beløb, double momsPct = 0.25)
        {
            return beløb * momsPct;
        }
        public static double gennemsnit(int[]månedsløn)
        {
            return månedsløn.Average();
        }

        public static void udskriv(string txt ="")
        {
            Console.WriteLine(txt);         
        }
//****************************************************************************

        public static void mdul5_2()
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };

            foreach (var d in test)
                Console.WriteLine(d);

            var res = BeregnOgSorterArray(test);

            Console.WriteLine("{0}  {1}",res.gennemsnit,res.sum);

            foreach (var d in test)
                Console.WriteLine(d);

        }

        private static Arrayresultat BeregnOgSorterArray(int[] test)
        {
            Arrayresultat ar;
            ar.gennemsnit = gennemsnit(test);
            ar.sum = test.Sum();
            Array.Sort(test);

            return ar;
            
        }

        struct Arrayresultat
        {
            public double sum;
            public double gennemsnit;
        }
//*************************************************************************
        public static void module5_3()
        {
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2,3));
            Console.WriteLine(Beregn(1, 2,4,5));


        }


        public static int Beregn(int a, int b)
        {
            return a+b;
        }

        public static int Beregn(int a, int b,int c)
        {
            return Beregn(a, b) + c;
        }

        public static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(a, b,c) + d;
        }
    }
}
