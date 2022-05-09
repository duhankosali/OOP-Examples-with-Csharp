namespace OOP.AbstractClassandMethods
{
    public class MaxHeap : Heap
    {
        public override int Extract() // Implement işlemi yapınca abstract method otomatik olarak buraya geliyor (override edilmiş olarak)
        {
            //throw new System.NotImplementedException();

            var item = _list.Max;
            _list.Remove(item);
            return item;
        }
    }
}
