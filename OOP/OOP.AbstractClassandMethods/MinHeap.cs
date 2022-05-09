namespace OOP.AbstractClassandMethods
{
    public class MinHeap : Heap
    {
        public override int Extract() // Implement işlemi yapınca abstract method otomatik olarak buraya geliyor (override edilmiş olarak)
        {
            //throw new System.NotImplementedException();

            var item = _list.Min;
            _list.Remove(item);
            return item;
        }
    }
}
