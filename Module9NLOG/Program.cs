using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9NLOG
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("Enter");
            logger.Debug("Nu Kaldes Test 1");
            test1(5, 5);
            logger.Debug("retur fra Test 1");

            
            logger.Debug("Nu Kaldes Test 2");
            test2();
            logger.Debug("retur fra Test 1");
            logger.Trace("exit");


            Console.WriteLine();

        }

        static void test1(int i , int x)
        {
            logger.Trace("Enter i,x {0}, {1}", i, x);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            logger.Trace("Estit 1");
        }

        static void test2()
        {
            logger.Trace("Enter");
            try
            {
                Console.WriteLine("test2");
            throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                //Console.WriteLine(ex.ToString());
                //throw;
            }
            logger.Trace("Estit 2");
        }
    }
}
