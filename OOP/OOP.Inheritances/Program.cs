using System;
using System.Collections.Generic;

namespace OOP.Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            //Polymorphism();

            var _s1 = new Rectangle(5, 10);
            Console.WriteLine($"{_s1.X} ve {_s1.Y}");

            var _s2 = new Circle(8,21);    
            Console.WriteLine($"{_s2.X} ve {_s2.Y}");

            var _s3 = new Square(15, 28);
            Console.WriteLine($"{_s3.X} ve {_s3.Y}");

            _s1.WorkWithDifferentObjects(_s2);
        }

        private static void Polymorphism()  
        {
            var shapes = new List<Shape>() // Shape türünden bir liste türettik ve bu listenin elemanlarını alt classlardan oluşturduk.
            {
                new Rectangle(),
                new Triangle(),
                new Circle(),
                new Square()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            new Square().Calculate(); // Square sınıfından Rectangle'ye özel olan methodları çağırabiliyoruz.
        }

        private static void NewMethod()
        {
            var _s1 = new Rectangle(); // şekil1
            var _s2 = new Triangle(); // şekil2
            var _s3 = new Circle(); // şekil3

            _s1.X = 20;
            _s1.Y = 20;
            Console.WriteLine($"x:{_s1.X} y:{_s1.Y}");
            _s1.Draw();

            _s2.X = 15;
            _s2.Y = 12;
            Console.WriteLine($"x:{_s2.X} y:{_s2.Y}");
            _s2.Draw();

            _s3.X = 18;
            _s3.Y = 14;
            Console.WriteLine($"x:{_s3.X} y:{_s3.Y}");
            _s3.Draw();
        }
    }
}
