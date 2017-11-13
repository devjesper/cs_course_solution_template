using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;


            var result = Convert.ToString(number, 2);
            Console.WriteLine(result + " " + number);

            number = number << 2;
            result = Convert.ToString(number, 2);
            Console.WriteLine(result + " " + number);

            Console.ReadLine();
        }

    }            
   
    

}
