using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Person
    {
        public string FirstName;
        public string LastName;
        private string FullName;


        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FullName = this.FirstName + " " + this.LastName;
        }
        public string Print()
        {
            return this.FirstName + " " + this.LastName;
        }

    }

}
