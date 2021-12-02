using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Advanced
{
    class AnonymousDemo
    {
        static void Main(string[] args)
        {
            var a = new { somekey = "x", somevalue = "value_of_x" };
            Console.WriteLine(a.somekey);
            Console.WriteLine(a.somevalue);
        }
    }
}
