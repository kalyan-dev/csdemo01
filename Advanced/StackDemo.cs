using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Advanced
{

    public class Stack<T> //where T:struct
    {
        private T[] data = new T[20];
        private int top = 0;

        //private T val = default(T);


        public void Push(T val)
        {
            data[top] = val;
            top++;
        }

        public T Pop()
        {
            T v = data[top-1];
            top--;
            return v ;
        }
    
        public void Print()
        {
            for(int i=top-1; i>=0; i--)
            {
                //// we can use the default value of T, as below
                //if (data[i].Equals(val))
                //    continue;
                Console.WriteLine(data[i]);
            }
        }
    }
    class StackDemo
    {
        static void Main(string[] args)
        {
            
            Stack<int> iStack = new Stack<int>();
            iStack.Push(45);
            iStack.Push(23);
            iStack.Push(6);
            iStack.Push(57);
            iStack.Print();
            Console.WriteLine($"Popped - {iStack.Pop()}");
            //var s1 = new Stack<int>();
            //s1.Push(29);



            Stack<string> s2 = new Stack<string>();
            s2.Push("Kashmir");
            s2.Push("Nepal");
            s2.Push("Bhutan");
            s2.Push("Himachal");
            s2.Push("Uttarakhand");
            s2.Push("Assam");
            s2.Print();

            Console.WriteLine($"Popped - {s2.Pop()}");
        }


    }
}
