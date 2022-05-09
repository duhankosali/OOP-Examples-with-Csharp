using System;

namespace OOP.Inheritances
{
    public class Square : Rectangle // Kare sınıfı Dikdörtgen sınıfından türetildi (Her kare bir dikdörtgendir. Her dikdörtgen bir şekildir.) --> Multi-Level Inheritance
    {
        // Not: Multi-Level Inheritance özelliği pek tercih edilmez. Büyük ölçekli projelerde problemlere neden olabilir.

        public Square()
        {

        }

        public Square(int x, int y) : base(x, y)
        {

        }

        new public void Calculate() // Hiding Method --> "new" anahtar sözcüğü ile Rectangle sınıfına ait bir methodu kullandık.
        {                           // Virtual ve override yönteminin alternatifi bir yoldur.
            Console.WriteLine("Calculate by Square");
        }
    }
}
