using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            // below warning is due to Obsolete attribute added to Add method
            Console.WriteLine(cal.Add(2, 3));
            List<int> lis = new List<int>() { 2, 3};
            Console.WriteLine(cal.Add(lis));
            Console.ReadKey();
        }
    }

    class Calculator
    {
        [Obsolete]
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(List<int> list)
        {
            int sum = 0;
            foreach(int a in list)
            {
                sum += a;
            }
            return sum;
        }
    }
}
