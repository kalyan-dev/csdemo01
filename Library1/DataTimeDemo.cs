using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Library1
{
    class DataTimeDemo
    {

        static void Main(string[] args)
        {
            var d1 = DateTime.Now;
            var d2 = DateTime.Parse("29-11-1021");
            var d3 = new DateTime(2021, 12, 31);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            var t2 = d1.Subtract(d2);
            Console.WriteLine(t2.Days);


        }

    }
}
