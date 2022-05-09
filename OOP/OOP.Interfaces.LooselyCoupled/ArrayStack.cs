using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.LooselyCoupled
{
    public class ArrayStack : IStack
    {
        public void Pop()
        {
            //throw new NotImplementedException();
            Console.WriteLine("ArrayStack.Pop()");
        }

        public void Push(int item)
        {
            //throw new NotImplementedException();
            Console.WriteLine("ArrayStack.Push({0})",item);
        }
    }
}
