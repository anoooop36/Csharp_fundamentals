using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stack;

namespace StackTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Creation()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.AreEqual(0, s.Size);
        }

        [Test]
        public void Push_Pop()
        {
            Stack<int> s = new Stack<int>(4);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            int value = s.Pop();
            Assert.AreEqual(3,value);
            Assert.AreEqual(2,s.Size);
        }

        [Test]
        public void ExceedLimit()
        {
            Stack<int> s = new Stack<int>(1);
            s.Push(1);
            Assert.Throws<ExceededSizeException>(() => s.Push(2));
        }
    }
}
