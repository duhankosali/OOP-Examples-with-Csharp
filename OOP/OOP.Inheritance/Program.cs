using System;

namespace OOP.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape classından kalıtım alıp oradaki özellikleri 3 farklı classta kullanıyorum.
            var _s1 = new Rectangle();
            var _s2 = new Circle();
            var _s3 = new Triangle();

            _s1.X = 10;
            _s1.Y = 22;
            _s1.Draw();

            _s2.X = 20;
            _s2.Y = 30;
            _s2.Draw();

            _s3.X = 15;
            _s3.Y = 31;
            _s3.Draw(); 
        }
    }
}
