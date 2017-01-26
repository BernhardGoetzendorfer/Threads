using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    public static class Program
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




        public static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod)); //Erzeuge einen Thread den ich kontrollieren kann. (Status, priorität...)
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread.");
                Thread.Sleep(700);
            }

            //t.Join(); //Was macht das? - Laut Buch: The Thread.Join method is called on the main thread to let it wait until the other thread finishes.



        }
    }
}
