using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTask.Generic
{
       public class StorageManager<T> where T : class, new()
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void GetAll()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Siyahı boşdur.");
                return;
            }

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public T FindByIndex(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                Console.WriteLine("Yanlış indeks.");
                return null;
            }

            return items[index];
        }
    }

}