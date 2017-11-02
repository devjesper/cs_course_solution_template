using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            //modul4 opgave 1
          //  Array();

            //modul4 opgave 2
            differenceStructAndClass();

            //modul4 
            stringPlay();

            Console.ReadLine();
        }

        private static void stringPlay()
        {

            string fornavn ="Ib";
            string efternavn = "Carl";

            string samlnavn = fornavn + ' ' + efternavn;
            string storNavn = samlnavn.ToUpper();
            string lilleNavn = samlnavn.ToLower();

            string del = samlnavn.Substring(3, 4);


            var split = samlnavn.Split(' ');

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.White;

            Console.WriteLine(split[0]);
        }

        public static void Array()
        {
            int[] a = new int[12];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 5000;

                int b = i % 4;

                switch (b)
                {
                    case 0:
                        a[i] += 2000;
                        break;
                    case 1:
                        a[i] -= 1000;
                        break;
                    case 2:
                        a[i] += 2500;
                        break;
                    case 3:
                        a[i] += 3000;
                        break;
                    default:
                        break;
                }

            }

            decimal gens = 0;
            System.Array.Sort(a);
            System.Array.Reverse(a);
            System.Array.Resize(ref a, 13);
            a[a.Length - 1] = 10;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                gens += a[i];

            }


            Console.WriteLine("gennemsnit {0}", (gens / a.Length).ToString("N2"));

            Console.ReadLine();



            int[][] test = new int[2][];
            test[0] = new int[10];
            test[1] = new int[4];

            int count = 0;
            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < test[i].Length; j++)
                {
                    test[i][j] = count;
                    count++;

                }

            }

            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < test[i].Length; j++)
                {
                    Console.Write("{0}  ", test[i][j]);


                }
                Console.WriteLine();

            }

            //int q = 0;
            //for (int j = 0; j < test[q].Length; j++)
            //{                
            //        for ( int i = 0; i < test.Length; i++)
            //        {
            //        Console.Write("{0}  ", test[i][j]);


            //    }
            //    Console.WriteLine();
            //    q++;
            //}


        }

        public static void differenceStructAndClass()
        {

            Person  k1 = new Person();
            Person k2 = new Person();
            k1.navn = "a";
            k2.navn = "b";

            Console.WriteLine(k1.navn+"  "+k2.navn);

            k1 = k2;

            Console.WriteLine(k1.navn + "  " + k2.navn);

            k1.navn = "c";

            Console.WriteLine(k1.navn + "  " + k2.navn);

            Person1 k3 = new Person1();
            Person1 k4 = new Person1();
            k3.navn = "a";
            k4.navn = "b";

            Console.WriteLine(k3.navn + "  " + k4.navn);

            k3 = k4;

            Console.WriteLine(k3.navn + "  " + k4.navn);

            k3.navn = "c";

            Console.WriteLine(k3.navn + "  " + k4.navn);

        }

        struct Person
        {
            public string navn;
        }

        class Person1
        {
            public string navn;
        }


    }
}
