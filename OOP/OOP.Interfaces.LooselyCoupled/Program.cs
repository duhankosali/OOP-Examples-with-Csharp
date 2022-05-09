using System;

namespace OOP.Interfaces.LooselyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack(new ArrayStack());

            stack.Push(5);
            stack.Pop();

            Console.WriteLine("-----------------------");

            var stack1 = new Stack(new LinkedListStack());

            stack1.Push(5);
            stack1.Pop();
        }
    }
}
