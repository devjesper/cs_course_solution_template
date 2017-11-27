using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10_using
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader stream = System.IO.File.OpenText(@"x:dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string Navne = stream.ReadLine();
                    Console.WriteLine(Navne);
                }
            }
            //stream.Close();
            //stream = null;

            Console.ReadLine();


        }
    }
}
