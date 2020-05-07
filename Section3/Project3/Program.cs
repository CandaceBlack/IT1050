using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instructors

            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            //Students
            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);

            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

            //Set Grade
            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);

            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            //Print
            Jane.Print();
            Joe.Print();

            Melissa.Print();
            Matt.Print();

            Console.WriteLine("Press any key to continue... ");
            Console.ReadKey();



        }
    }
}
