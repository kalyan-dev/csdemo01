using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Advanced
{
    class Point
    {
        public int X;
        public int Y;
    }

    static class ExtensionMethods123
    {
        public static void Print(this Point p)
        {
            Console.WriteLine($"(X,Y):{p.X}:{p.Y}");
        }

        public static bool Compare(this Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }
    }

    class ExtensionMethodsDemo
    {
        static void Main(string[] args)
        {
            var p1 = new Point { X = 10, Y = 20 };
            //Console.WriteLine(p1);
            var p2 = new Point { X = 20, Y = 20 };

            p1.Print();

            Console.WriteLine(p1.Compare(p2));
        }

    }
}
