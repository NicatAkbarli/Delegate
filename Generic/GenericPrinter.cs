using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTask.Generic
{
    public class GenericPrinter<T>
    {
        public void PrintItem(T item)
        {
            Console.WriteLine(item);
        }

        public void PrintList(List<T> items)
        {
            if (items == null || items.Count == 0)
            {
                Console.WriteLine("Siyahı boşdur.");
                return;
            }

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}