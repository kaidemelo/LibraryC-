using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ");
            var firstBook = new Book();
            firstBook.setTitle("Hunger Games");
            var secondBook = new Book();
            secondBook.setTitle("Cooking Book");
            var library = new List<Book>();
            library.Add(firstBook);
            library.Add(secondBook);

            try
            {
                var bookIndex = int.Parse(Console.ReadLine());
                Console.WriteLine(library[bookIndex].getTitle());
            }
            catch (Exception e)
            {
                Console.WriteLine("Na fam.");
            }
        }
    }
}