﻿namespace Module01_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("bla");
            // mor bla

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
