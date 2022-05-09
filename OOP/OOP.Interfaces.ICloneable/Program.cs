using System;

namespace OOP.Interfaces.ICloneables
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReferenceTypeProblem(); // BU PROBLEMİN ÇÖZÜMÜ İÇİN ICloneable kullanıyoruz

            var book1 = new Book() { Id = 1, Price = 25.5, Title = "Suç ve Ceza" }; // bir kitap nesnesi oluşturuyoruz.

            var book2 = (Book)book1.Clone(); // book1 referansını book2 ye atadık. Ancak bu sefer farklı olarak Clone() kullandık.
            Console.WriteLine(book2.Title);

            book2.Title = "Sefiller";

            Console.WriteLine(book2.Id + " " + book2.Title);
            Console.WriteLine(book1.Id + " " + book1.Title); 



            Console.ReadLine();
        }

        private static void ReferenceTypeProblem()
        {
            var book1 = new Book() { Id = 1, Price = 25.5, Title = "Suç ve Ceza" }; // bir kitap nesnesi oluşturuyoruz.

            var book2 = book1; // book1 referansını book2 ye atadık.
            Console.WriteLine(book2.Title);

            book2.Title = "Sefiller";

            Console.WriteLine(book2.Title);
            Console.WriteLine(book1.Title); // !!! book2 'de değişiklik yaptık ancak iki nesnede de değişiklik görüldü. 
                                            // Çünkü referans ataması yaptık ve referans üzerindeki değişiklik ikisinide etkiliyor.

            // Referans tiplerde bu problemi çözebilmek için "ICloneable" interface kullanılır.
        }
    }
}
