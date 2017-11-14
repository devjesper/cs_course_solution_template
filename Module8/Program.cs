using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            //modul8_1();
            modul8_2();



            // Person [] person = new Oerson[]

            Console.ReadLine();
        }

        public static void modul8_2()
        {

            Dyr[] dyrs = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyrs[i] = Dyr.TilfældigtDyr();

            }


            foreach (var item in dyrs)
            {
                Console.WriteLine(item.SigNoget());

            }           



        }

        public static void modul8_1()
        {
            Person p1 = new Person()
            {
                Fornavn = "Ib",
                Efternavn = "Hansen"

            };

            Console.WriteLine(p1.FuldtNavn());

            Elev p2 = new Elev()
            {
                Fornavn = "Else",
                Efternavn = "Hansen",
                KlasseLokale = "A"


            };
            Console.WriteLine(p2.FuldtNavn());


            //Instruktør p3 = new Instruktør()
            Person p3 = new Instruktør()
            {
                Fornavn = "Karl",
                Efternavn = "Hansen",
                NøgleId = 1

            };

            Console.WriteLine(p3.FuldtNavn());
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public   string FuldtNavn()
        {
            return "jeg hedder "+Fornavn + " " + Efternavn +" og er en person";
        }
    }
    class Elev :Person
    {
        public string KlasseLokale { get; set; }
        public   string FuldtNavn()
        {
            return "jeg hedder " + Fornavn + " " + Efternavn + " og er en Elev i klasse " + KlasseLokale;
        }

    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
        public  string FuldtNavn()
        {
            //return "jeg hedder " + Fornavn + " " + Efternavn + " og er en instruktør";
            return $"jeg hedder {Fornavn} {Efternavn} er instrtuktør og har nøgle {NøgleId} ";
        }
    }


    class Dyr
    {
        private static Random rnd = new Random();
        public string Navn { get; set; }

       
        public static Dyr TilfældigtDyr()
        {
            int tal = 0;
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            tal = rnd.Next(0, navne.Length);

            if (tal%2==0)
             return new Hund() { Navn = navne[tal] };
            else
                return new Kat() { Navn = navne[tal] };
        }

        public virtual string SigNoget()
        {
            return $"Jeg er et dyr og hedder {Navn}";
        }
    }
    class Hund : Dyr
    {
        public override string SigNoget()
        {
            return $"Jeg er en hund og hedder {Navn}";
        }
    }

    class Kat : Dyr
    {
        public override string SigNoget()
        {
            return $"Jeg er en kat og hedder {Navn}";
        }
    }
}
