using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Advanced
{
    class FindAllDemo
    {

        static bool isLargeName(string msg)
        {
            return msg.Length > 5;
        }

        static void Main(string[] args)
        {
            string[] names = { "Bill Gates", "Larry Page", "Larry Ellison", "Dell", "James" };

            //1st way 
            var lnames = Array.FindAll(names, isLargeName);
            foreach (var n in lnames)
                Console.WriteLine(n);

            //2nd way , Anonymous Method
            var snames = Array.FindAll(names, delegate (string s)
            {
                return s.Length < 5;
            });
            foreach (var n in snames)
                Console.WriteLine(n);

            //3rd way, Lambda
            var selectedNames = Array.FindAll(names, s => s.Length == 5);
            foreach (var n in selectedNames)
                Console.WriteLine(n);
        }
    }
}
