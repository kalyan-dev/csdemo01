using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.EFDemo
{
    class ListInventory
    {
        static void Main(string[] args)
        {
            var ic = new InventoryContext();

            foreach (var c in ic.Categories)
                Console.WriteLine($"{c.CategoryName.PadRight(30)}    -   {c.CategoryCode}");


            //foreach (var b in ic.books)
            //    Console.WriteLine(b.Title);
        }
    }
}
