using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Arrays_And_Lists2_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my Strings and Arrays Program. I hope you enjoy!");
            Console.WriteLine("Press ENTER to begin.");
            Console.ReadLine();

            string[] strArray = { "Shoe", "Banana", "Towel", "Dry-Rotten-Piece-Of-Wood", "Balloon" };

            Console.WriteLine("Please, choose  a number. Your number must be whole, and between 0 and 4... OR ELSE!!");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > strArray.Length - 1)
            {
                Console.WriteLine("I WARNED YOU! NOW YOU'LL HAVE TO TRY AGAIN!");
                Console.ReadLine();
                Environment.Exit(-1);

            }

            else {
                Console.WriteLine("A " + strArray[Convert.ToInt32(num)] + " is your weapon.. " + "A " + strArray[Convert.ToInt32(num)] + "...AHHHHAHAHAHAAA!!!!");
            }

            Console.WriteLine("Please press ENTER, if you dare to continue.");
            Console.ReadLine();


            int[] intArray = { 3, 5, 6, 9, 15 };

            Console.WriteLine();
            Console.WriteLine("MWAHAHAAAA..\n NOW AGAIN! Choose another number, just like before it must be whole, between 0 and 4, and OR ELSE!!");

            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 > intArray.Length - 1)
            {
                Console.WriteLine("I WARNED YOU! NOW YOU'LL HAVE TO TRY AGAIN!");
                Console.ReadLine();
                Environment.Exit(-1);
            }

            else
            {
                Console.WriteLine("A Lvl:" + intArray[Convert.ToInt32(num)] + " " + (strArray[Convert.ToInt32(num)] + "... " + "LVL:" + intArray[Convert.ToInt32(num)] + "!!! AAAAAAAAAAAAHHHHAHAHAHAAA!!!!"));
            }      

            Console.WriteLine("Well your fate has been sealed, good luck on your journey.. er.. I forgot to get you a name. \n Please, press ENTER to Continue.");
            Console.ReadLine();

            List<string> strList = new List<string>();
            strList.Add("Brave");
            strList.Add("Eager");
            strList.Add("Dull");
            strList.Add("Chunky");
            strList.Add("Mellow");

            Console.WriteLine("Okay okay: A number, whole, between 0 and 4... OR ELSE!!");

            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num3 > strArray.Length - 1)
            {
                Console.WriteLine("I WARNED YOU!!! NOW YOU'LL HAVE TO TRY AGAIN!");
                Console.ReadLine();
                Environment.Exit(-1);

            }

            else
            {
                Console.WriteLine("NOW, your fate has been sealed " + strList[Convert.ToInt32(num3)] + " One. " + "Best of luck on your journey!" + "\n Press ENTER to Continue.");
            }

            Console.ReadLine();




            Console.WriteLine("Thank you for viewing my program. Have a good day.");
            Console.ReadLine();
            
            
        }
    }
}
