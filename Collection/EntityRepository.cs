using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection
{
    public class EntityRepository<T> where T : class
    {
        private List<T> items= new List<T>();

        public void Add (T item)
        {
            items.Add (item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public T GetByID(Func<T,bool> predicate)
        {
            return items.FirstOrDefault (predicate);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }
    }
}