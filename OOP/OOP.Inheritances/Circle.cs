using System;

namespace OOP.Inheritances
{
    public class Circle : Shape // Çember sınıfı Shape sınıfından türetildi (Her çember bir şekildir)
    {
        public Circle()
        {

        }

        public Circle(int x, int y) : base(x,y)
        {

        }

        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Circle drawing task...");
        }
    }
}
