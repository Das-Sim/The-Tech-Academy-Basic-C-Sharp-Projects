using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! That was quite an impact, but the ship is still in tact! Can you tell me what day it is?"); //2a. Prompt the user to enter the current day of the week.
            string startingDay = Console.ReadLine(); //3a. Assign the value to a variable of that enum data type you just created.

            try
            {
                DaysOfTheWeek day1 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), startingDay);
                Console.WriteLine(day1 + "?\n We'd better get moving..");
                Console.ReadLine();
                Console.WriteLine("Thank you for viewing my program. Have a good day.");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week. Because of your actions, today's day is: DOOMS DAY! AND THE PROGRAM WILL NOW END!");             
            }
            Console.Read(); //4b. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
        }

        

        public enum DaysOfTheWeek //1a. Create an enum for the days of the week.
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        } 
    }
}
