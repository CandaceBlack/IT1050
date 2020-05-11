using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] People = new Person[3];

            People[0] = new Person("Candace", "Black");
            People[1] = new Person("Andre", "Patton");
            People[2] = new Person("Salena", "Wagstaff");

            foreach (Person person in People)

            {
                person.Print();
            }
            System.Console.ReadLine();
            System.Console.WriteLine("Press any key to continue... ");
            System.Console.ReadKey();
        }
    }
}
