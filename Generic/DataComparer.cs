using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTask.Generic
{
    public class DataComparer<T> where T : IComparable<T>
    {
        public T FindMax(T a, T b)
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }

        public T FindMin(T a, T b)
        {
            return a.CompareTo(b) <= 0 ? a : b;
        }
    }
}