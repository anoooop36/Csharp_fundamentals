using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class IndexedNames
    {
        string[] arr = new string[10];
        int length = 10;
        public int Length
        {
            get
            {
                return length;
            }
        }
        public IndexedNames()
        {
            for (int i = 0; i < length; i++)
            {
                arr[i] = "N.A.";
            }
        }
        public string this[int index] {
            get
            {
                if(index>=0 && index<length)
                    return arr[index];
                return "";
            }
            set
            {
                if (index >= 0 && index < length)
                    arr[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Anoop";
            names[1] = "Ajay";
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
