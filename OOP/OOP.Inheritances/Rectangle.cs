using System;

namespace OOP.Inheritances
{
    public class Rectangle : Shape // Dikdörtgen sınıfı Shape sınıfından türetildi (Her dikdörtgen bir şekildir)
    {

        public Rectangle()
        {

        }

        public Rectangle(int x, int y) : base(x, y) // "base" yani Shape class 'daki constructor a bağlandık.
        {
            //X = x;
            //Y = y;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle drawing task...");
            base.Draw();
        }

        public void Calculate()
        {
            Console.WriteLine("Calculate by Rectangle");
        }
    }
}
