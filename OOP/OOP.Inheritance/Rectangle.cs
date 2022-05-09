using System;

namespace OOP.Inheritance
{
    public class Rectangle : Shape // Dikdörtgen sınıfı şekil sınıfından kalıtım alıyor. (Çünkü her dikdörtgen bir şekildir)
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Rectangle drawing task..."); // override işlemi
        }
    }
}
