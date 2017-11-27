using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11_Collection_Kortbunke
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.tilføjkort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.tilføjkort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.tilføjkort(new Kort() { Kulør = "Ruder", Værdi = 3 });

            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();

            k = b.FjernKort();
            k = b.FjernKort();
            k = b.FjernKort();

            Console.ReadLine();

        }
    }
    
    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }

    class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void tilføjkort(Kort nytkort)
        {
            bunke.Push(nytkort);
        }

        public Kort FjernKort()
        {
            if(bunke.Count>0)
                return bunke.Pop();
            return null;

        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item.ToString());
            }
            
        }

    }
}
