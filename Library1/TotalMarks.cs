using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Library1
{
    class TotalMarks
    {
        static void Main(string[] args)
        {
            string input = "89,44,55,,64;78";
            var total = 0;
            ////option 1
            //List<String> marks = (input.Split(',', ';')).ToList<String>();

            //option 2
            String[] marks = input.Split(',', ';');

            foreach (var m in marks)
                //Console.WriteLine(m);

                try
                {
                    total += Int32.Parse(m);
                }
                catch(Exception ex)
                {
                    //throw new InvalidCastException();
                    Console.WriteLine(ex.Message);
                }
            Console.WriteLine($"Total Marks= {total}");



        }
    }
}
