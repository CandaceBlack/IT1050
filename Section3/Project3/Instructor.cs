﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Instructor
    {
        private string FirstName = "none";
        private string CourseName = "none";

        public Instructor(string FirstName, string CourseName)
        {
            this.FirstName = FirstName;
            this.CourseName = CourseName;
        }
        public void SetStudentGrade(Student Name, int Grade)
        {
            Name.SetGrade(Grade);
        }

        public string PrintInstructorInfo()
        {
            return this.FirstName + " " + " (Course: " + this.CourseName + ")";
        }
    }
}