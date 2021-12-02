using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Library1
{
    class Person: IComparable<Person>
    {
        public string name;
        public string email;
        public int age;

        public Person(string name, string email,int age)
        {
            this.name = name;
            this.email = email;
            this.age = age;
        }

        public override bool Equals(Object obj)
        {
            var p = obj as Person;
            return this.name == p.name && this.email == p.email;
        }

        public override int GetHashCode()
        {
            return this.age;
        }

        public override string ToString()
        {
            return $"{this.name} [{this.age}] - {this.email}";
        }

        public int CompareTo(Person p)
        {
            return this.age - p.age;
        }




    }
    class ObjectDemo
    {

        static void Main(string[] args)
        {
            var p1 = new Person("James", "abc@gmail.com", 34);
            var p2 = new Person("Sarah", "sarah@abc.com", 46);

            //Console.WriteLine(p2);

            //Console.WriteLine(p1);
            //Console.WriteLine(p1.Equals(p2));


            Person[] persons =
            {
                new Person("James", "abc@gmail.com", 34),
                new Person("Manish", "gsfabc@gmail.com", 23),
                new Person("Victor", "afdfabc@gmail.com", 6),
                new Person("Sejal", "abafc@gmail.com", 12)
            };

            Array.Sort(persons);

            foreach (var p in persons)
                Console.WriteLine(p);


        }
    }
}
