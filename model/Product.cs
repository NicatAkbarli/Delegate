using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTask.model
{
     public class Product
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Product: {Name}";
        }
    }
}