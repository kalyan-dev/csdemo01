using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.EFDemo
{
    class ListBooks
    {
        static void Main(string[] args)
        {
            var bc = new BooksContext();
            Console.WriteLine("EF Demo...");

            /*
            foreach (var b in bc.books)
                //Console.WriteLine(b);
                Console.WriteLine($"{b.Title.PadRight(30)}   -   {b.Price}");

            */

            foreach (var b in bc.books.Where(b => b.Title.Contains("C#")))
                Console.WriteLine(b.Title);


            var selectedBooks = from b in bc.books
                                where b.Price > 500
                                select b.Title;


            foreach (var b in selectedBooks)
            {
                Console.WriteLine(b);
            }


        }
    }
}
