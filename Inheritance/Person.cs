using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Person
    {
        public int PersonId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public abstract void Register(params string[] course);
    }

    class Student : Person
    {
        public string Major { get; set; }

        public override void Register(params string[] course)
        {
            //Register Student for selected courses in database
            //Charge fees to accounts
            Console.WriteLine("Registered successfully");
        }
    }

    class Faculty : Person
    {
        public string OfficeLocation { get; set; }

        public override void Register(params string[] course)
        {
            Console.WriteLine("Enjoy your Registration Discount");
        }
    }
}
