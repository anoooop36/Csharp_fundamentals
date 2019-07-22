using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ExceededSizeException : Exception { }
    public class PopProhibitedException : Exception { }
    public class Stack<T>
    {
        private T[] stackArray;
        private int maxSize;
        public int Size { get; private set; }

        public Stack(int length)
        {
            maxSize = length;
            stackArray = new T[maxSize];
        }

        public void Push(T val) {
            if (Size >= maxSize)
            {
                throw new ExceededSizeException();
            }
            stackArray[Size++] = val;
        }
        public T Pop()
        {
            if (Size ==0)
            {
                throw new PopProhibitedException();
            }
            return stackArray[--Size];
        }
    }
    public class MyClass
    {
        static void Main(string[] args)
        {
        }
    }
}
