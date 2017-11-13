using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant(8, 4);
            Console.WriteLine(t1.Grundlinje);
            Console.WriteLine(t1.Højde);
            Console.WriteLine( t1.Areal);

            Console.ReadLine();

        }
    }

    class Trekant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        private double areal;

        public double Areal 
        {
            get { return areal = Grundlinje * Højde * 0.5; }
            
        }
        

        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }


    }
}
