using GenericsTutorial.Interfaces;

namespace GenericsTutorial.RealWorldExample
{


    internal class Repository<T> where T : IEntity
    {
        private List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public T GetById(int id)
        {
            return _items.FirstOrDefault(i => i.Id == id);
        }
    }
}
