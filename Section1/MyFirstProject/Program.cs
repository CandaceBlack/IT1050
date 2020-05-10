using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("What is your first name? ");
            string firstName = System.Console.ReadLine();


            System.Console.Write("What is your middle initial? ");
            string middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            string lastName = System.Console.ReadLine();

            string fullName = firstName + " " + middleInitial + ". " + lastName;


            System.Console.Write("How tall are you in feet? ");
            int heightFeet = int.Parse(Console.ReadLine());

            System.Console.Write("How many inches beyond your base height are you? ");
            double heightInches = double.Parse(Console.ReadLine());

            const double multiplier = 2.54;
            const int inchesPerFoot = 12;

            double inches = (heightFeet * inchesPerFoot) + heightInches;
            double totalHeightCM = inches * multiplier;

            System.Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("Are you a US Citizen?: (True/False) ");
            bool isCitizen = bool.Parse(Console.ReadLine());

            bool canVote = (age >= 18) && isCitizen;

            System.Console.WriteLine();
            System.Console.WriteLine("Your full name is: '" + fullName + "'.");
            System.Console.WriteLine();
            System.Console.WriteLine("Your height in CM is: '" + totalHeightCM + "'.");
            System.Console.WriteLine();
            System.Console.WriteLine("Your voter eligibility is: '" + canVote + "'.");
            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();











        }
    }
}
