using System;

namespace OOP.Inheritance
{
    public class Shape // Şekil sınıfı (Base Class - Temel Sınıf)
    {
        // Properties
        public int X { get; set; }
        public int Y { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }
        
        // Methods
        public virtual void Draw() // virtual method --> Yani bu fonksiyonu alt sınıflarda override edebiliriz.
        {
            Console.WriteLine("Base class drawing task...");
        }
    }
}
