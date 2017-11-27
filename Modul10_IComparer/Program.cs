using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10_IComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };

            Array.Sort(hunde);

            foreach(var item in hunde)
            {
                Console.WriteLine(item.Navn+" " +item.Alder);
            }

            Console.ReadLine();
        }
    }

    class Hund:IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h1 = obj as Hund;

            if (h1.Alder > this.Alder)
                return -1;
            if (h1.Alder < this.Alder)
                return 1;
            return 0;

        }
    }
}
