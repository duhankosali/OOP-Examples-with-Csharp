using System;

namespace OOP.Inheritances
{
    public class Triangle : Shape // Üçgen sınıfı Shape sınıfından türetildi (Her üçgen bir şekildir)
    {
        public Triangle()
        {

        }

        public Triangle(int x, int y) : base(x, y)
        {

        }

        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Triangle drawing task...");
        }
    }
}
