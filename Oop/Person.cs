using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Oop
{
    class Person
    {
        public string name { get; set; }
        public string email { get; set; }
    }


    class testPerson
    {

        static void Main(string[] args)
        {

            // We can create objects in this way, ONLY WHEN there is no Constructor in the class;
            Person p1 = new Person { name= "James", email="abc@xyz.com" };

            var p2 = new Person { email = "xyz@abc.com", name = "Kevin" };

        }

    }

}
