using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01
{
    class Factors
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter a Number:");
            n = Int32.Parse(Console.ReadLine());

            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    Console.WriteLine($"{i} is a factor of {n}");
        }
    }
}
