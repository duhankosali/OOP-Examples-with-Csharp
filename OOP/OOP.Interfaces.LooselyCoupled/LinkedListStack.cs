using System;

namespace OOP.Interfaces.LooselyCoupled
{
    public class LinkedListStack : IStack
    {
        public void Pop()
        {
            //throw new NotImplementedException();
            Console.WriteLine("LinkedList.Pop()");
        }

        public void Push(int item)
        {
            //throw new NotImplementedException();
            Console.WriteLine("LinkedList.Push({0})",item);
        }
    }
}
