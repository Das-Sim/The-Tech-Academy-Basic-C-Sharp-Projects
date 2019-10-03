using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Approval_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?: ");
            Console.WriteLine(" 'True' or 'False' ");
            bool drinksAndDrives = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?: ");
            int caughtSpeeding = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool insuranceApproved = (age > 15 && drinksAndDrives == false && caughtSpeeding < 3);
            Console.WriteLine(insuranceApproved);
            Console.WriteLine("Have a nice day!");

            Console.ReadLine();
        }
    }
}