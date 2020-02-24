using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Product
    {
        public Product(string code)
        {
            Code = code;
        }
        public String Code { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public virtual string GetDisplayText => Code;

        //expression bodied Member
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
        public override string ToString() => $"{Code} : {Price}";
    }

    class Book : Product
    {
        public Book(string code):base(code)
        {
            // Old school way to solve problem of default.
            //Author = "Unknown";
        }

        /// <summary>
        /// The author of the book. 
        /// Default is Unknown.
        /// </summary>
        public string Author { get; set; } = "Unknown";

        public override string ToString()
        {
            return base.ToString() + $" writen by {Author}";
        }
    }

    class Software : Product
    {
        public Software() : base(null)
        {
        }

        //Hides Base class implementation
        //public new string GetDisplayText => Version;

        //To override must use virtual in base case
        public override string GetDisplayText => Version;

        public string Version { get; set; }
    }
}
