using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTask.Generic
{
       public class Calculator<T> where T : struct
    {
        public T Add(T a, T b)
        {
            double result = Convert.ToDouble(a) + Convert.ToDouble(b);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public T Multiply(T a, T b)
        {
            double result = Convert.ToDouble(a) * Convert.ToDouble(b);
            return (T)Convert.ChangeType(result, typeof(T));
        }
    }

}