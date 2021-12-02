using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Library1
{
    class WriteNames
    {
        static void Main(string[] args)
        {

            var sw = new StreamWriter(@"C:\WS_2021\netplayer\csdemo01\misc\names.txt");

            while (true)
            {
                Console.WriteLine("Enter a word(END to terminate..):");
                var word = Console.ReadLine();
                if (word == "END")
                    break;
                sw.WriteLine(word);
            }
            sw.Close();
                
        }
    }
}
