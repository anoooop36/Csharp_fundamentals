using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);
namespace DelegateMulticasting
{
    class Program
    {
        static int num = 10;
        public static int Add(int p)
        {
            num = num + p;
            return num;
        }

        public static int Multiply(int p)
        {
            return num * p;
        }
        static void Main(string[] args)
        {
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(Program.Add);
            NumberChanger nc2 = new NumberChanger(Program.Multiply);
            nc = nc1;
            nc += nc2;
            Console.WriteLine(nc(10));
            Console.ReadKey();
        }
    }
}
