using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Advanced
{
    class DelegateDemo
    {

        // create a delegate called "GreetDelegaete" which can point to a function
        // which "returns nothing and takes a string as parameter"

        public delegate void GreetDelegaete(string name);


        //create such a function for demo
        static void Greet(string name)
        {
            Console.WriteLine("Hello "+ name);
        }

        static void Main(string[] args)
        {
            var d1 = new GreetDelegaete(Greet);
            d1("Sourav");   //now we can assume that "d1 and Greet" are Synonymous;
            d1.Invoke("Reetu");


            GreetDelegaete d2 = Greet;
            d2("Bunny");

            GreetDelegaete d3 = delegate (string s)
            {
                Console.WriteLine("using delegate keyword");
            };

            d3("option 3");


            //using lambda expression

            GreetDelegaete d4 = s => Console.WriteLine(s);
            d4("Good Bye!");
        }

    }
}
