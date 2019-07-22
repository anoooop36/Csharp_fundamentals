using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateNuGetPackages
{
    public class Program
    {
        public int Add(List<int> numArgs)
        {
            int sum = 0;
            foreach (var num in numArgs)
            {
                sum += num;
            }
            return sum;
        }
    }
}
