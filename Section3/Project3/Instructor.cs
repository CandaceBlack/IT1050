﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            Console.WriteLine("Instructor " + this.Name + "teaches" + this.CourseName + ".");
        }
    }
}