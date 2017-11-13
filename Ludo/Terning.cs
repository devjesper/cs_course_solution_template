using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    class Terning
    {
        private static System.Random rnd = new Random();

        public int værdi;
        private bool snyd;
        


        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
        }

        public void Ryst()
        {
            if (snyd)
                værdi = 6;
            else
                værdi = rnd.Next(1, 7);
        }

        public  void Skriv()
        {
            Console.WriteLine("["+værdi+"]");
        }


    }
}
