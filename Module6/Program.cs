using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());
            p1.fornavn = "bent";
            p1.efternavn = "hansen";
            p1.fødselsår = 1970;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());


            Person p2 = new Person("ib", "per", 2000);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());

            Console.ReadLine();

        }
    }

    class Person
    {
        public string fornavn;
        public string efternavn;
        public int fødselsår;

        public Person() : this("", "", 0)
        {
            //this.fornavn = "";
            //this.efternavn = "";
        }

        public Person(string fornavn,string efternavn, int fødselsår)
        {
            this.fornavn = fornavn.ToUpper();
            this.efternavn = efternavn.ToUpper();
            this.fødselsår = fødselsår;
        }

        public string FuldtNavn()
        {
            return fornavn + " " + efternavn;
        }

        public int Alder()
        {
            DateTime dt = DateTime.Now;           

            return dt.Year - fødselsår;
        }







    }

}
