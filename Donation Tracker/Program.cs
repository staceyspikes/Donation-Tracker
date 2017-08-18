using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();
            Console.WriteLine(address);

            Console.WriteLine("What is your email address?");
            string emailAddress = Console.ReadLine();
            Console.WriteLine(emailAddress);

            Console.WriteLine("What is the fiscal year?");
            string fiscalYear = Console.ReadLine();
            Console.WriteLine(fiscalYear);

            Console.WriteLine("How many dollar bills are you donating?(numerical value)");
            int dollarNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(dollarNumber * 1);

            Console.WriteLine("How many five dollar bills are you donating?(numerical value)");
            int fiveDollarNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(fiveDollarNumber * 5);

            Console.WriteLine("How many ten dollar bills are you donating?(numerical value)");
            int tenDollarNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(tenDollarNumber * 10);

            Console.WriteLine("How many fifty dollar bills are you donating?(numerical value)");
            int fiftyDollarNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(fiftyDollarNumber * 50);

            Console.WriteLine("How many hundred dollar bills are you donating?(numerical value)");
            int hundredDollarNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(hundredDollarNumber * 100);

            Console.WriteLine("How many quarters are you donating?(numerical value)");
            int quarterNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(quarterNumber * .25);

            Console.WriteLine("Total Donation");







            





        }
    }
}
