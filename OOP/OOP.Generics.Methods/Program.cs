using System;

namespace OOP.Generics.Methods
{
    class Program
    {
        // Önemli Not: Eğer bir methodu herhangi bir nesne oluşturmadan önce çağırmak istiyorsak "static" olarak tanımlamamız gerekir.

        // İki değişkenin değerlerini değiştiren method.
        public static void Swap<T>(ref T x, ref T y) // ref type --> class olmak zorunda.
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Console.WriteLine($"a = {a} , b = {b}");

            Swap<int>(ref a, ref b);

            Console.WriteLine($"a = {a} , b = {b}");


            Console.WriteLine(new string('-',15));


            char c1 = 'A'; 
            char c2 = 'B';

            Console.WriteLine($"c1 = {c1} , c2 = {c2}");

            Swap<char>(ref c1, ref c2);

            Console.WriteLine($"c1 = {c1} , c2 = {c2}");

            Console.ReadKey();
        }
    }
}
