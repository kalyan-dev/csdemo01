using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01
{
    class FuncDemo
    {

        static void Main(string[] args)
        {
            ////pass by value
            //Console.WriteLine(Max(45, 63));

            ////pass by reference
            //int v = 100;
            //Zero(ref v);
            //Console.WriteLine(v);


            ////Default Parameters, Named Parameters;
            //Line(20,'*');
            //Console.WriteLine();
            //Line(10);
            //Console.WriteLine();
            //Line(ch: '6');
            //Console.WriteLine();
            //Line(l: 10);


            //String[] s = { "Bill", "Sam", "Noyal", "Gary", "Angel" };
            //Greet2("Hello", s);

            ////Variable number of parameters;
            //Greet("Hello", "Bill", "Sam", "Noyal", "Gary", "Angel");
            //Greet("Hi", "Bill", "Sam", "Noyal");

            //output parameters; 
            int x,y;
            TakeValues(out x, out y);
            Console.WriteLine($"x={x}, y={y}");


            // output test 2; This is also working; 
            // Change the values of the parameters.. calling by ref; or passing as Output parameters;
            int m =0, n = 0;
            TakeValues2(ref m, ref n);
            Console.WriteLine($"m={m}, n={n}");




        }

        static void TakeValues2(ref int a, ref int b)
        {
            Console.WriteLine("Enter a Number:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter another Number:");
            b = Int32.Parse(Console.ReadLine());
        }

        static void TakeValues(out int a,out int b)
        {
            Console.WriteLine("Enter a Number:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter another Number:");
            b = Int32.Parse(Console.ReadLine());
        }

        static int Max(int x,int y)
        {
            return x>y ? x : y;
        }

        static void Zero(ref int v)
        {
            v = 0;
        }

        static void Line(int l=10, char ch='-')
        {
            for (int i=1; i<=l; i++)
            {
                Console.Write(ch);
            }
        }

        static void Greet(String msg, params String[] names) {

            foreach (string n in names)
                Console.WriteLine($"{msg} {n}");

        }

        static void Greet2(String msg, String[] names)
        {

            foreach (string n in names)
                Console.WriteLine($"{msg} {n}");

        }
    }
}
