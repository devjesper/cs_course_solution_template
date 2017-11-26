using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.MinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Ip", "000000-0000");
            KursusDeltager k = new KursusDeltager("Anne", "111111-1111");
            k.Skriv();
            Console.WriteLine(Elev.CprOK("111"));

            Instruktør i = new Instruktør("Michell", "222222-2222", "Nøgleid");
            i.Skriv();

            Elev e = new Elev("Ib", "333333-3333",2);
            e.Skriv();

            Person[] pers = new Person[3];
            pers[0] = k;
            pers[1] = i;
            pers[2] = e;
            Console.WriteLine();
            Console.WriteLine();

            foreach (var p in pers)
            {
                p.Skriv();
            }

            Console.WriteLine("");

            Console.ReadLine();

        }
    }


}
