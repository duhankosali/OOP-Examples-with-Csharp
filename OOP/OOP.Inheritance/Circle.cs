using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Circle : Shape // Çember sınıfı şekil sınıfından kalıtım alıyor. (Çünkü her Çember bir şekildir)
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Circle drawing task..."); // override işlemi
        }
    }
}
