using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Oop
{

    class Student
    {

        protected string name, email, college;

        public Student(string name, string email, string college) {
            this.name = name;
            this.college = college;
            this.email = email;
        }

        public virtual void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.email);
            Console.WriteLine(this.college);
        }
    }

    class ForeignStudent : Student
    {
        protected string country;

        public ForeignStudent(string name,string email,string college,string country)
            :base(name,email,college)
        {
            this.country = country;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.country);
        }

    }

    class inhDemo
    {
        static void Main(string[] args)
        {

            //ForeignStudent f1 = new ForeignStudent("Jack2", "jack2@abc.com", "AUCE", "Srilanka");
            //f1.Print();

            Student s1 = new ForeignStudent("Jack", "jack@abc.com", "JNTU", "China");
            s1.Print();

            ForeignStudent f2 = s1 as ForeignStudent;
            f2.Print();

            s1 = new Student("Kevin", "kvn@abc.com", "AKPS");
            Console.WriteLine(s1 is ForeignStudent);
            s1.Print();

        }
        
        



    }
}
