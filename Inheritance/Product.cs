using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Product
    {
        public String code { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"{code} : {Price}";
        }
    }

    class Book : Product
    {
        public string Author { get; set; }
    }

    class Software : Product
    {
        public string Version { get; set; }
    }
}
