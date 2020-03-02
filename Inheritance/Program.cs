using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p;
            Console.WriteLine("Are you stu?");
            string input = Console.ReadLine();
            if(input == "yes" || input == "y")
            {
                p = new Student();
                Console.WriteLine("What is your major?");
                string major = Console.ReadLine();

                Student currStu = p as Student;
                currStu.Major = major;
            }
            else
            {
                p = new Faculty();
            }
            p.FullName = "Jane Doe";
            p.Email = "Fake@fake.com";
            p.Register("CPW101", "CPW150");

            //ProductTesting();
        }

        private static void ProductTesting()
        {
            Product p = new Product("XYZ")
            {
                Code = "Money"
                            ,
                Description = ""
                            ,
                Price = 999.99
            };

            Book b = new Book("ZYX")
            {
                Code = "ABC123"
                ,
                Description = ""
                ,
                Price = 9.99
                //, Author = "Me"
            };

            Software s = new Software
            {
                Code = "Makayla's Software",
                Description = "",
                Price = 119.99,
                Version = "1.2.3.1"
            };
            DisplayProduct(s);
            DisplayProduct(p);
            DisplayProduct(b);
            Console.ReadKey();
        }

        private static void DisplayProduct(Product p)
        {
            //if(p.GetType == typeof(Book) or nameOf(Book))
            int i = 5;
            i++;
            Console.WriteLine(i);
            i++;

            if(p is Book)
            {
                Book b = p as Book;
                Console.WriteLine($"Check out this thrilling story!" +
                    $" Written by: {b.Author}");
            }

            // AutoGenerates ToString() not neccessary to type(Optional).
            Console.WriteLine(p.ToString() + "\n");
        }
    }
}
