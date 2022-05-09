using System.Collections;
using System.Linq;
using System;

namespace OOP.Interfaces.IEnumerables
{
    public class Array : IEnumerable
    {
        // Tam sayıları organize eden bir dizi yapısı

        private int[] InnerList { get; set; } // sınıf içerisinde kullanacağımız yapı.
        private int index = 0; // dizi üzerine eleman yerleştirme.

        public Array(int size = 16) // constructor 
        {
            InnerList = new int[size];
        }

        public Array(params int[] initial) // overloading constructor
        {
            InnerList = new int [initial.Length];

            foreach (var item in initial)
            {
                InnerList[index++] = item;
                // index++;
            }
        }

        public IEnumerator GetEnumerator() // IEnumerable interface ile gelen method.
        {
            //throw new System.NotImplementedException();

            //return InnerList.Take(index).GetEnumerator();  

            return new ArrayEnumerator(InnerList);
        }
    }
}
