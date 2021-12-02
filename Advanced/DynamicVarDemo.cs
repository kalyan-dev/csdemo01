using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csdemo01.Oop;

namespace csdemo01.Advanced
{
    class DynamicVarDemo
    {

        static Product getProduct()
        {
            return new Product("Phone", 10000, 20);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Object Type[Product/Account]:");
            var t = Console.ReadLine();

            dynamic d = new { };
            if (t == "Product")
            {
                d = getProduct();
            }
            else if (t == "Account")
            {
                d = new Account(4000, "Sumit");
                d.Deposit(50000);
            }

            d.Print();


        }
    }
}
