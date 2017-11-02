using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{

    
    class Program
    {
        static void Main(string[] args)
        {
            // 1)
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            //2)
            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            //3)
            FilTyper ft = FilTyper.pdf;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            //4)
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("yyyyMdd"));

            //5)

            Person p1;
            p1.id =99;
            p1.Navn = "Mikkel";

            Console.WriteLine(p1.Navn + " " + p1.id);

            Console.ReadLine();

        }

        enum FilTyper
        {
            csv,
            pdf,
            txt
        }

        struct Person
        {
            public int id;
            public string Navn;
        }




    }
    
}
