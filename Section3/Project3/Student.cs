using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.Grade = 0;
            this.Grade += grade;
        }

        public void Print()
        {
            Console.WriteLine("Name" + this.Name + " has a " + this.Grade + "from" + this.Teacher + "." );
            
            Teacher.Print();
        }

    }
}
