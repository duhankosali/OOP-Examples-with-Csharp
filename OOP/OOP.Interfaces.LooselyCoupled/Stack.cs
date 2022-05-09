using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.LooselyCoupled
{
    public class Stack : IStack
    {
        private readonly IStack _stack; 

        public Stack(IStack stack) // constructor --> Dependency Injection işlemi
        {
            _stack = stack;
        }

        // IStack interface ile gelen methodlar.
        public void Pop()
        {
            //throw new NotImplementedException();
            _stack.Pop();
        }

        public void Push(int item)
        {
            //throw new NotImplementedException();
            _stack.Push(item);
        }
    }
}
