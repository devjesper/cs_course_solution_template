using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("formatex {0}", );
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine($"invalid {ex}");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("overflow {}");
            }
            catch (Exception ex)
            {

                Console.WriteLine("The exception");
            }

            Console.ReadLine();
        }

        private static void Run()
        {
            Console.WriteLine("indtast 1 tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("indtast 2 tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int res = tal1 + tal2;
            Console.WriteLine($"res = {res}");

            


        }
    }
}
