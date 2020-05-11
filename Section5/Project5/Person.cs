using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Person
    {
        public string firstName;
        public string lastName;
    
        public Person(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }
        public void Print()
        {
            string fullName = firstName + " " + lastName;
            System.Console.WriteLine(fullName);
        }

    }

}
