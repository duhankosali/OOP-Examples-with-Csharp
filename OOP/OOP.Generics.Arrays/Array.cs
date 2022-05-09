using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics.Arrays
{
    // T --> Type , Generic Yapı
    public class Array<T> : IEnumerable
        // Kısıtlama (Constraints)
        where T : class, new() // Sınıfın alacağı Generic ifade class (Referans tipli) olmalıdır.
    {
        private T[] InnerList; // dizimiz
        private int index; // dizi içinde dolaşabilmek için index

        public Array(int size = 16) // constructor
        {
            InnerList = new T[size]; // Herhangi bir şey belirtilmediyse otomatik 16 boyutlu dizimiz oluşuyor.
            index = 0;
        }

        public Array(params T[] collection) // overloading constructor
        {
            InnerList = new T[collection.Length]; // içeriye alınan eleman kadar boyut. (params operatörü sayesinde)
            index = 0;

            foreach (var item in collection) // dizimize girilen parametre kadar eleman ekleme.
            {
                InnerList[index] = item;
                index++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();

            return InnerList.Take(index).GetEnumerator();
        }
    }
}
