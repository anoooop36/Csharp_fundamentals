using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateNuGetPackages;

namespace ConsumeLocalNuGetPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateNuGetPackages.Program p = new CreateNuGetPackages.Program();
            Console.WriteLine(p.Add(new List<int> { 1,2,3,4,5}));
            Console.WriteLine();
        }
    }
}
