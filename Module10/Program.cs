using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {

            IDBFunktioner[] i = new IDBFunktioner[4];

            i[0]= new Ubåd();
            i[1] = new Hund();
            i[2]= new Ubåd();
            i[3] = new Hund();

            foreach (var item in i)
            {
               ((Ibla) item).Dab();

            }

            Ibla[] b = new Ibla[4];

            for(int p =0; p<4;p++)
            {
                b[p] = (Ibla) i[p];
            }

            foreach (var item in b)
            {
                item.Dab();

            }
            Console.ReadLine();



        }
    }

    class Hund:IDBFunktioner,Ibla
    {
        public string Navn { get; set; }

        public void Dab()
        {
            Console.WriteLine("Hund dabber..");
        }

        void IDBFunktioner.Gem()
        {
            Console.WriteLine("Gemmer Hund....");
        }
    }

    class Ubåd:IDBFunktioner,Ibla
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void Dab()
        {
            Console.WriteLine("Ubåd dabber..");
        }

        void IDBFunktioner.Gem()
        {
            Console.WriteLine("Gemmer Ubåd....");
        }
    }

    interface IDBFunktioner
    {
        void Gem();
    }

    interface Ibla
    {
        void Dab();
    }
}
