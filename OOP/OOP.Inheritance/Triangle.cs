using System;

namespace OOP.Inheritance
{
    public class Triangle : Shape // Üçgen sınıfı şekil sınıfından kalıtım alıyor. (Çünkü her Üçgen bir şekildir)
    {
        public override void Draw() // Draw bir tür virtual method olduğu için override işlemi yapabiliyorum.
        {
            //base.Draw();
            Console.WriteLine("Triangle drawing task..."); // override işlemi
        }
    }
}
