using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.GetInfo();
            Console.WriteLine();

            Person p2 = new Person();
            p2.GetInfo();
            Console.WriteLine();

            Console.WriteLine();
            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();

            Person.SumOfAllAges = (p1.Age + p1.Spouse.Age + p2.Age + p2.Spouse.Age);
            int numberOfPeople = 4;

            Console.WriteLine("Average Age: " + Person.SumOfAllAges / numberOfPeople);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
