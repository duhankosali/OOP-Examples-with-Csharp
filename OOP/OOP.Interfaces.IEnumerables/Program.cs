using System;

namespace OOP.Interfaces.IEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enumerables --> Numaralandırılabilir.

            // Defina an array --> dizi tanımlama
            var CustomArr = new Array(1,3,5,7,9); 
            var arr = new int[] {1,3,5,7};

            // predefined array (Elemanları klasik bastırma yöntemi)
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 25)); // Görsel amaçlı.

            // IEnumerable ile bastırma yöntemi !!!
            foreach (var item in CustomArr) 
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();    
        }
    }
}
