using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads2
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: " + i);
                Thread.Sleep(700); // Sleep, Die Zeit wie lange das Programm warten soll, 
                                   // bis das nächste Statement ausgeführt wird
            }
        }


        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart())



        }
    }
}
