using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);

namespace Delegates
{
    class Program
    {
        static int n = 10;
        public static int Add(int p)
        {
            return n + p;
        }
        public static int Multiply(int p)
        {
            return n * p;
        }
        static void Main(string[] args)
        {
            NumberChanger dl1 = new NumberChanger(Program.Add);
            NumberChanger dl2 = new NumberChanger(Program.Multiply);
            Console.WriteLine(dl1(20));
            Console.WriteLine(dl2(20));
            Console.ReadKey();
        }
    }
}
