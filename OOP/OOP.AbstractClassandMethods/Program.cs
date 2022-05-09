using System;

namespace OOP.AbstractClassandMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 3, 8, 5, 4 };
            var minHeap = new MinHeap();
            var maxHeap = new MaxHeap();

            foreach (var item in arr)
            {
                minHeap.Insert(item);
                maxHeap.Insert(item);
            }

            Console.WriteLine(minHeap.Extract());
            Console.WriteLine(maxHeap.Extract());

            Console.ReadKey();
        }
    }
}
