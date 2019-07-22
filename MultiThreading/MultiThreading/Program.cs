using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        public static void CallToChildTread()
        {
            Console.WriteLine("Child thread starts");
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildTread);
            Console.WriteLine("In main: creating the child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
