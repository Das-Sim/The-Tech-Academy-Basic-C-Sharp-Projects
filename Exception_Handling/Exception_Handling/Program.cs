using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("\nHELLOOO DOWN THERE! This my exception handling ladder.\n Please, Press ENTER to begin your ascent.");
            Console.ReadLine();
            List<int> intList = new List<int>() { 1090, 2000, 5000, 2300, 5220, 1000, 5400 };          
            foreach (int num in intList)
            {
                Console.WriteLine(num);
            }

            Console.Write("\nThere are different ladders to choose from! \n Curious? You think it will take too long to get to the top?\n Please, be my guest, give me any whole number and I will divide your ladders by it. ");
            Console.WriteLine();
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSo " + num1 + " huh..");
            foreach (int num in intList)
            {
                Console.WriteLine("Ladder: " + num + " divided by " + num1 + " equals " + (num / num1) + " moves.");
            }
        }


        catch (FormatException ex)
        {
            Console.WriteLine("\nPlease use a whole number.");
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("\nPlease no dividing by zero..");
        }

        Console.WriteLine("\nNow falling off the exception handling ladder!! Enjoy the rest of the game!");
        Console.WriteLine("Press ENTER to continue.");
        Console.ReadLine();

        Console.WriteLine("Thank you for viewing my program. Have a good day.");
        Console.ReadLine();
    }
}