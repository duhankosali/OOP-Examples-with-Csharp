using System;

namespace OOP.Inheritances
{
    public class Shape // Base Class (Temel sınıfım) --> Diğer sınıflar bu sınıftan türetilecek.
    {
        public Shape() // constructor
        {

        }

        public Shape(int x, int y) // overloading edilmiş constructor
        {
            X = x;
            Y = y;
        }

        // Properties
        public int X { get; set; }
        public int Y { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

        // Methods
        public virtual void Draw() // Virtual method --> Alt sınıflardan override edilebilir.
        {
            //Console.WriteLine("Shape Drawing task...");
            Console.WriteLine(" ");
        }

        public void WorkWithDifferentObjects(object o)
        {
            // AS OPERATÖRÜ
            Shape shapeFromParameter = o as Shape; // as ifadesi başarılıysa aynen çalışır, eğer başarız ise null değer döndürür. Bu nedenle bir if bloğu yazacağız.

            if(shapeFromParameter != null) // "as" operatörü yanlış durumlarda NullReferenceException vermesin diye bir if bloğu yazdık.
            {
                shapeFromParameter.Draw();
            }


            // IS OPERATÖRÜ
            if(o is Shape) // o'nun Shape olup olmama durumuna göre "true" veya "false" değer döndürür.
            {
                // With ...
            }
            
        }
    }
}
