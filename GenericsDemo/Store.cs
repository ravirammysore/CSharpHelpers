
namespace GenericsDemo
{
    class Store<T>
    {
        private T[] items;

        public Store()
        {
            items = new T[500];            
        }
        public void Add(T item, int position)
        {
            if(0<=position && position<items.Length)
                items[position] = item;
        }
        
        public void Remove(int position)
        {
            items[position] = default;
        }

        public T Get(int position)
        {
            return items[position];
        }
    }
}
