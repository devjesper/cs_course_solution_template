using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Modul2HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Indtast navn");

            string  a = ReadLine();

            WriteLine("Velkommen {0} {1}", a.ToUpper(), 500);

            ReadKey();




        }
    }
}
