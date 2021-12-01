using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01
{
    class HighPrices
    {
        static void Main(string[] args)
        {
            // to find the prices which are higher than the average price
            int[] prices = { 500, 340, 560, 234, 55, 666, 333, 373, 120, 482 };

            int sum = 0;
            float avg = 0;
            for (int i = 0; i < prices.Length; i++)
                sum += prices[i];

            avg = sum / prices.Length;

            Console.WriteLine($"Average Price= {avg:####.00}");

            // option-1
            //for (int i = 0; i < prices.Length; i++)
            //    if (prices[i] > avg)
            //        Console.WriteLine(prices[i]);


            //option-2
            foreach (int i in prices)
                if (i > avg)
                    Console.WriteLine(i);
        }
    }
}
