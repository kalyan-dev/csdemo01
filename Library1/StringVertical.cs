using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Library1
{
    class StringVertical
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            var s1 = Console.ReadLine();

            //vertical
            foreach (var ch in s1)
                Console.WriteLine(ch);

            //reverse
            for (int i = s1.Length - 1; i >= 0; i--)
                Console.Write(s1[i]);
        }
    }
}
