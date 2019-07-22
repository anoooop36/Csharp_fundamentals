using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManagingThreads
{
    class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
            int sleepfor = 5000;
            Console.WriteLine("Child thread paused for {0} seconds", sleepfor/1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }
        static void Main(string[] args)
        {
            ThreadStart childRef = new ThreadStart(CallToChildThread);
            Console.WriteLine("In main: creating the child thread");
            Thread childThread = new Thread(childRef);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
