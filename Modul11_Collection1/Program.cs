using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11_Collection1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<person> p = new List<person>();

            p.Add(new person() { Id = 1, Navn = "Ib" });
            p.Add(new person() { Id = 3, Navn = "Per" });
            p.Add(new person() { Id = 7, Navn = "Carsten" });

            foreach (var item in p)
            {
                Console.WriteLine(item.Id + "  "+ item.Navn); 
            }


            Dictionary<int,person> d = new Dictionary<int, person>();

            d.Add(500, new person() { Id = 20, Navn = "Nam" });
            d.Add(600, new person() { Id = 30, Navn = "Nam1" });
            d.Add(700, new person() { Id = 40, Navn = "Nam2" });

            //var bla = d.ElementAt(2);
            var bla = d[600];
            //Console.WriteLine(bla.Key + " value:"+ bla.Value.Id + " " + bla.Value.Navn  ) ;
            Console.WriteLine(bla.Navn +" "+ bla.Id);

            Console.ReadLine();
        }
    }

    class person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

    }

}
