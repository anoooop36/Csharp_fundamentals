using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DestroyingThreads
{
    class Program
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread starts");
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child thread completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread abort exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the thread Exception");
            }
        }
        public static void MethodToCallChild()
        {
            try
            {
                Console.WriteLine("Child thread starts");
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Second Method "+counter);
                }
                Console.WriteLine("Child thread completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread abort exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the thread Exception");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart childRef = new ThreadStart(CallToChildThread);
            ThreadStart childRef2 = new ThreadStart(MethodToCallChild);
            Console.WriteLine("In main: Creating the child thread");
            Thread childThread = new Thread(childRef);
            Thread childThread2 = new Thread(childRef2);
            childThread.Start();
            childThread2.Start();
            // stop the main thread for some time
            Thread.Sleep(2000);
            // now abort the child
            Console.WriteLine("In main: Aborting the child thread");
            childThread.Abort();
            Console.ReadKey();
        }
    }
}
