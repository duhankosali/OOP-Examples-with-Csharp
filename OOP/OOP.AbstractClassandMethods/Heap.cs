using System.Collections.Generic;

namespace OOP.AbstractClassandMethods
{
    public abstract class Heap // Eğer abstract bir methodum varsa, sınıfımda daima abstract olmalıdır..
    {
        // Field
        protected SortedSet<int> _list;

        public Heap()
        {
            _list = new SortedSet<int>();
        }

        public void Insert(int item) // Ekleme işlemi. Alt sınıflarda ortak olarak kullanılabiliyor.
        {
            _list.Add(item);
        }

        // Çıkarma işlemi için abstract method tanımlayacağız.
        public abstract int Extract(); // Çıkarma işlemi. Alt sınıflarda ortak olarak kullanılamaz çünkü abstract olarak tanımlandı.
    }
}
