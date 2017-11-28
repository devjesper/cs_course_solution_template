using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12_Delegate
{
    class Program
    {
        //public delegate int Beregn(int av, int bv);
        static void Main(string[] args)
        {
            int res = 0;
            //Beregn b = Plus;
            //b += Minus;
            //res = Beregner(2, 4, b);
            //Console.WriteLine(res);

            //Func<int, int, int> q = Plus;
            //q += Minus;
            //res = Beregner(2, 4, q);
            //Console.WriteLine(res);


            res = Beregner(2, 4, Plus);            
            Console.WriteLine(res);
            res = Beregner(2, 4, Minus);
            Console.WriteLine( res);
           

            Console.WriteLine(Beregner(4,5,(x,y)=>x*y+47)); // definere den delegate den sender over til Beregner-funktionen

            Console.ReadLine();
        }

        /*******************************************
         * Løsning 2
         * ****************************************************/
        public static int Beregner(int a, int b, Func<int,int,int> delegateberegner)
        {
            int c = 0;

            c = delegateberegner(a, b);             

            return c;
            //eller
            //return delegateberegner(a, b);             
        }

        /*******************************************
         * Løsning 1
         * ****************************************************/
        //public static int Beregner(int a,int b,Beregn delegateberegner)
        //{
        //    int c = 0;

        //    c = delegateberegner(a, b);
                /*************************************************
                 * Traverser en liste af delegates
                 * *************************************************/
        //    //foreach (var item in delegateberegner.GetInvocationList())
        //    //{
        //    //    c +=(int)item.DynamicInvoke(a, b);
        //    //}       


        //    return c;
            //eller
            // return delegateberegner(a, b);

        //}

        public static int Plus(int a,int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
