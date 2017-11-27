using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11_GenericsSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Swap(ref a, ref b);

        }


        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
