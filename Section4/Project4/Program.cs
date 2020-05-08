using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)

        {
            const double COST_MATINEE_ADULT = 5.99;
            const double COST_MATINEE_CHILD = 3.99;
            const double COST_MATINEE_SENIOR = 4.50;

            const double COST_EVENING_ADULT = 10.99;
            const double COST_EVENING_CHILD = 6.99;
            const double COST_EVENING_SENIOR = 8.50;

            const double COST_SMALL_SODA = 3.50;
            const double COST_LARGE_SODA = 5.99;
            const double COST_HOTDOG = 3.99;
            const double COST_POPCORN = 4.50;
            const double COST_CANDY = 1.99;

            double Ticket = 0;
            double Concession = 0;
            double Promotion = 0;
            double Promo1 = 0;
            double Promo2 = 0;
            double Promo3 = 0;

    
            int adults = 0;
            int children = 0;
            int seniors = 0;

            int numSmSoda = 0;
            int numLgSoda = 0;
            int numHotDg = 0;
            int numPopCrn = 0;
            int numCandy = 0;

            System.Console.Write("Is this ticket for an evening show? (Y/N): ");
            bool isEvening = System.Console.ReadLine().ToLower().StartsWith("Y");

            //Tickets
            System.Console.WriteLine();

            System.Console.Write("How many adult tickets?: ");
            adults = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many child tickets?: ");
            children = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many senior ticket?: ");
            seniors = int.Parse(System.Console.ReadLine());

            
            //Concession
            System.Console.WriteLine();

            System.Console.Write("How many small sodas would you like? ");
            numSmSoda = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many large sodas would you like? ");
            numLgSoda = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many hotdogs would you like? ");
            numHotDg = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many popcorns would you like? ");
            numPopCrn = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many candies would you like? ");
            numCandy = int.Parse(System.Console.ReadLine());

            Concession += numSmSoda * COST_SMALL_SODA;
            Concession += numLgSoda * COST_LARGE_SODA;
            Concession += numHotDg * COST_HOTDOG;
            Concession += numPopCrn * COST_POPCORN;
            Concession += numCandy * COST_CANDY;

            Ticket += adults * (isEvening ? COST_EVENING_ADULT : COST_MATINEE_ADULT);
            Ticket += children * (isEvening ? COST_EVENING_CHILD : COST_MATINEE_CHILD);
            Ticket += seniors * (isEvening ? COST_EVENING_SENIOR : COST_MATINEE_SENIOR);


            //Promotions
            Promotion = Promo1 + Promo2 + Promo3;

            if (numPopCrn > 1 && numLgSoda >=1)
            {
                Promo1 = 2;
            }

            else
            {
            }

            if (Ticket >= 3 && isEvening)
            {
                Promo2 = COST_POPCORN * 1;
            }

            else
            {
            }

            if (numCandy >=3)
            {
                int freeCandy = numCandy / 4;
                Promo3 = freeCandy * 1.99;
            }
            else
            {

            }

            double TotalPrice = Ticket + Concession - Promotion;
            System.Console.WriteLine();
            System.Console.WriteLine("Your ticket price is: " + Ticket);
            System.Console.WriteLine("Your concession price is: " + Concession);
            System.Console.WriteLine("Your promotions total: " + Promotion);
            System.Console.WriteLine("Your total price is: " + TotalPrice);

            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to continue..." );
            System.Console.ReadKey();
        }
    }
}
