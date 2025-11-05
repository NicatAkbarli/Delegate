using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTask.Generic
{
    public class Repository<T> where T : class, new()
    {
        private List<T> data = new List<T>();

        public void Add(T item)
        {
            data.Add(item);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= data.Count)
            {
                Console.WriteLine("Yanlış indeks.");
                return;
            }

            data.RemoveAt(index);
        }

        public int Count()
        {
            return data.Count;
        }

        public void GetAll()
        {
            if (data.Count == 0)
            {
                Console.WriteLine("Siyahı boşdur.");
                return;
            }

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}