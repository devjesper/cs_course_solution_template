using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12_Events_Filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {

            //System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;

            w.Created += W_Created;
            w.Changed += W_Changed;
            w.Deleted += W_Deleted;

            do
            {

            } while (true);
        }

        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("CREATE" + e.Name);
        }

        private static void W_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("dELETED" + e.Name);
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("CAHNGED " +e.Name);
        }
    }
}
