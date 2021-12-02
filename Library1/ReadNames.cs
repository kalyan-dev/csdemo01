using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csdemo01.Library1
{
    class ReadNames
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"C:\WS_2021\netplayer\csdemo01\misc\names.txt");

            while (true)
            {
                var line = sr.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
                else
                    break;
            }
            sr.Close();
        }
    }
}
