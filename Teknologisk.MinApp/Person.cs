using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.MinApp
{
    public abstract class Person
    {
        protected string Cpr;

        public string Navn { get; set; }

        public Person(string navn, string cpr)
        {
            Cpr = cpr;
            Navn = navn;

        }
        
        public virtual void Skriv()
        {
            Console.WriteLine($"Navn {Navn} med cpr {Cpr}");
        }

        public static bool CprOK(string CPR)
        {
            return CPR.Length == 11 && CPR.Substring(6, 1) == "-";

        }
    }

    public class KursusDeltager : Person
    {
        public KursusDeltager(string navn, string cpr):base(navn,cpr)
        { }

    }

    public class Elev:KursusDeltager
    {
        public int ElevId { get; set; }

        public Elev(string navn,string cpr, int id):base(navn,cpr)
        {
            this.ElevId = id;
        }

        public override void Skriv()
        {
            Console.WriteLine($"ElevNavn {Navn} med cpr {Cpr} elevid {ElevId}");
        }
    }

    public class Instruktør:KursusDeltager
    {
        public string Nøgle { get; set; }

        public Instruktør(string navn, string cpr, string nøgle):base(navn,cpr)
        {
            this.Nøgle = nøgle;
        }

        public override void Skriv()
        {
            Console.WriteLine($"InstruktørNavn {Navn} med cpr {Cpr} og nøgle {Nøgle}");
        }
    }

}
