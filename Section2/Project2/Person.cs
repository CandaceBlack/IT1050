using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.LastName + ", " + this.FirstName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName() + " (" + this.Age + ")");
        }

        public void GetInfo()
        {
            System.Console.WriteLine("What is your first name? ");
            this.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name? ");
            this.LastName = System.Console.ReadLine();

            System.Console.WriteLine("How old are you? ");
            this.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is your spouse's first name? ");
            this.Spouse = new Person();
            this.Spouse.FirstName = System.Console.ReadLine();
            this.Spouse.LastName = this.LastName;

            System.Console.WriteLine("How old is your spouse? ");
            this.Spouse.Age = int.Parse(System.Console.ReadLine());


        }

    }
}
