using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP.Generics.Arrays
{

    class Program
    {
        static void Main(string[] args)
        {
            //GenericListDefination();   // ARRAY

            //GenericLinkedList();    // LINKED LIST

            //Generic_List();  // LIST YAPISI

            //GenericStack(); // STACK

            var arr1 = new Array<Book>(
                new Book(1,"Sefiller",30),
                new Book(2,"Suç ve Ceza",40),
                new Book(3,"Devlet",50)
                );

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------------");




            // Array<T> ' de T ifadesinin bir class olması gerektiğini belirttik. (Array.cs incele, 41)
            // Bu nedenle Struct yapıda olan Company derlenirken hata veriyor !!!

            var arr2 = new Array<Company>( // !!!! Üst satır oku
                new Company() { Id = 1, Name = "Aselsan", Country = "Türkiye" },
                new Company() { Id = 2, Name = "Trendyol", Country = "Türkiye" },
                new Company() { Id = 3, Name = "Sahibinden", Country = "Türkiye" }
                );

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }

        private static void GenericStack()
        {
            var stack = new Stack<Company>(); // Generic stack
            stack.Push(new Company() { Id = 1, Name = "Aselsan", Country = "Türkiye" });

            Console.WriteLine(stack.Peek().Name);
        }

        private static void Generic_List()
        {
            // ArrayList içine pek çok farklı türden eleman alabilir. Ancak bu elemanlar ilk başta object olarak saklanır.
            var arrayList = new List<int>();
            // Boxing --> Kutuya eleman ekleme.
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add('a');

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //var x = arrayList[0] * 10; // Böyle bir yapı hata verir. Çünkü arrayList "object" türde bir yapıdır.
            // Unboxing --> Kutudan eleman çıkarma, işlemi ile bu problemi çözeceğiz.
            var x = (int)arrayList[2] * 10;
            Console.WriteLine(x);
        }

        private static void GenericLinkedList()
        {
            var list = new LinkedList<Book>(); // Generic yapı olarak bir nesne de alabiliriz.

            //list.AddFirst(new Book() { Id = 1, Title = "Sol Ayağım", Price = 10 });
            //list.AddFirst(new Book() { Id = 2, Title = "Sefiller", Price = 8 });
            //list.AddLast(new Book() { Id = 3, Title = "Hayvan Çiftliği", Price = 12 });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void GenericListDefination() // array
        {
            var arrInt = new Array<int>(1, 3, 5, 7, 9, 11, 13, 15, 17); // Array Generic bir class olduğu için <int> belirtmemiz gerekiyor.
            foreach (var item in arrInt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------");

            var arrChar = new Array<char>('D', 'U', 'H', 'A', 'N'); // Array Generic bir class olduğu için <char> belirtmemiz gerekiyor.
            foreach (var item in arrChar)
            {
                Console.Write(item + " ");
            }

        }
    }
}
