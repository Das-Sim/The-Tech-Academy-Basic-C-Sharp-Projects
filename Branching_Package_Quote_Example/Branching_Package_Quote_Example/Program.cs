using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();

            Console.WriteLine("Please enter package weight: ");
            string pWeight = Console.ReadLine();
            int weight = Convert.ToInt32(pWeight);


            //if for when Package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width: ");
            string pWidth = Console.ReadLine();
            int width = Convert.ToInt32(pWidth);

            Console.WriteLine("Please enter the package height: ");
            string pHeight = Console.ReadLine();
            int height = Convert.ToInt32(pHeight);

            Console.WriteLine("Please enter the package length: ");
            string pLength = Console.ReadLine();
            int length = Convert.ToInt32(pLength);


            decimal pSize = width + height + length;
            if (pSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            decimal quote = pSize * weight / 100.00m;
            Console.WriteLine("Your estimated total for shipping this package is : $" + quote + "\r\nThank you.");
            Console.ReadLine();

        }
    }
}