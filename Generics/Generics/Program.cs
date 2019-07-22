using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size+1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> arr = new MyGenericArray<int>(10);
            for (int i = 0; i < 10; i++)
            {
                arr.SetItem(i,i*10);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr.GetItem(i));
            }

            Console.ReadKey();
        }
    }
}
