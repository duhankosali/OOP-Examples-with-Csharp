using System;
using System.Collections.Generic;

namespace OOP.Interfaces.IEnumerates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IEnumerator --> Numaralandırıcı

            //Console.WriteLine("Hello World!");

            var collection = new List<Product>
            {
                new Product { 
                    ProductId = 1,
                    ProductName = "Buzdolabı",
                    Price = 12000
                },

                new Product {
                    ProductId = 2,
                    ProductName = "Ocak",
                    Price = 8500
                },

                new Product {
                    ProductId = 3,
                    ProductName = "Kahve Makinesi",
                    Price = 2500
                },

                new Product {
                    ProductId = 1,
                    ProductName = "Bulaşık Makinesi",
                    Price = 5000
                },

                new Product {
                    ProductId = 1,
                    ProductName = "Fırın",
                    Price = 8250
                },

            };

            foreach (var product in collection)
            {
                Console.WriteLine($"{product.ProductId} {product.ProductName} {product.Price}");
            }

            Console.WriteLine(new string ('-', 25)); // Görsel amaçlı.

            // Yukarıdaki Foreach ın bir alternatifi.
            IEnumerator<Product> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext()) // MoveNext --> Mevcut örnekten sonra bir örnek daha varsa burası True döner.
            {
                Console.WriteLine($"{enumerator.Current.ProductId} {enumerator.Current.ProductName} {enumerator.Current.Price}");
            }

            Console.ReadKey();
    }
    }
}
