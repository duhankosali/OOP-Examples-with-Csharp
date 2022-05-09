using System.Collections;

namespace OOP.Interfaces.IEnumerables
{
    internal class ArrayEnumerator : IEnumerator
    {
        // field
        private int[] InnerList; // dizi için.
        private int index; // dizi içinde dolaşım için.

        // constructor
        public ArrayEnumerator(int[] arr)
        {
            InnerList = arr;
            index = -1; // Henüz herhangi bir eleman almadım (elemanlar 0 dan başlar)
        }


        // IEnumerator interface ile gelen methodlar
        public object Current => InnerList[index];

        public bool MoveNext() // Eleman sayısını aştığımda MoveNext false döner. 
        {
            //throw new System.NotImplementedException();

            // Bir sonraki eleman var mı yok mu?
            if (index == -1)
            {
                index = 0;
                return true;
            }

            if (index < InnerList.Length - 1)
            {
                index++;
                return true;    
            }

            else // dizinin sonuna geldiysek en başa yollayacak şartları sağlıyoruz.
            {
                index = -1;
                return false;
            }
        }

        public void Reset() // Reset --> Başlangıç durumu.
        {
            //throw new System.NotImplementedException();

            index = -1;
        }
    }
}