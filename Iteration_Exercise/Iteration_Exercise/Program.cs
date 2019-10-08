using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        string[] player = { "Archer", "Smither", "Medic", "Tanker", "Warrior", "Ninja", "Airian" };

        Console.WriteLine("\nWelcome, here are the available class types to pick from:\n");
        for (int i = 0; i < player.Length; i++)
        {
            Console.WriteLine(player[i]);
        }

        Console.WriteLine();
        Console.Write("Please enter you name.\n");
        string text = Console.ReadLine();

        for (int i = 0; i < player.Length; i++)
        {
            player[i] += " " + text;
        }

        Console.WriteLine();

        for (int i = 0; i < player.Length; i++)
        {
            Console.WriteLine(player[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Excellent. Now, we must do some super secret loops in order to maniuplate the rng of the game to ensure a top notch gaming experience for you, the player. \nPlease, Press ENTER.");
        Console.ReadLine();

        // Iinfinite loop
        //for (int j = 1; j > 0; j++)
        //{
        //    Console.WriteLine(j);
        //}
        // Iinfinite loop END

        // Fixed Infinite loop
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        // Fixed Infinite Loop END

        Console.WriteLine();
        Console.WriteLine("That loop there was nearly infinite! That could have crashed our game, luckily, we fixed the loop! Moving on... \n Please press ENTER to continue.");
        Console.ReadLine();

        // Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine("WHEW! Another close call! This loop here, we closed it by using one of them '<' operators. Don't worry, all according to plan! \n Please press ENTER to continue.");
        Console.ReadLine();

        // Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator END

        // Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine("Yep! As expected, the operator '<=' seems to work at stopping the awful infite loop! Now finally we are ready to move on. \n Please press ENTER to continue.");
        Console.ReadLine();
        // Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator END

        List<string> startingArea = new List<string>() { "Mountains", "Underwater", "Beachside", "Forest", "Desert", "Plains", "Volcanic" };

        Console.WriteLine("\nHere are the available starting biomes:");
        Console.WriteLine();
        foreach (string map in startingArea)
        {
            Console.WriteLine(map);
        }

        Console.WriteLine();
        Console.Write("Enter the biome you would like to begin in.\n");
        string sMap = Console.ReadLine();

        int mapNum = 0;
        bool mPresent = false;

        foreach (string map in startingArea)
        {

            if (map.Equals(sMap))
            {
                Console.WriteLine();
                Console.WriteLine(map + " Diffculty: " + mapNum);
                mPresent = true;
                break;
            }
            mapNum++;
        }

        if (!mPresent)
        {
            Console.WriteLine(sMap + " not available.");
        }
        Console.WriteLine();
        Console.WriteLine("Please press ENTER to continue.");
        Console.ReadLine();

        List<string> weather = new List<string>() { "Rainy", "Sunny", "Windy", "Overcast", "Meteor Shower", "Sunny", "Blizzard" };

        Console.WriteLine("Weather conditions will make all the difference in your starting biome. Choose Wisely.");
        Console.WriteLine();
        foreach (string condition in weather)
        {
            Console.WriteLine(condition);
        }

        Console.WriteLine();
        Console.Write("Enter the name of your weather condition.");
        Console.WriteLine();
        string mWeather = Console.ReadLine();

        int wNum = 0;
        bool wPresent = false;
        List<int> wIndex = new List<int>();

        Console.WriteLine();

        foreach (string condition in weather)
        {

            if (condition.Equals(mWeather))
            {
                wIndex.Add(wNum);
                wPresent = true;
            }
            wNum++;
        }


        if (!wPresent)
        {
            Console.WriteLine(mWeather + " not available.");
        }
        else
        {            
            Console.Write(mWeather + " " + sMap + " Difficulty: ");
            foreach (int num in wIndex)
            {
                Console.Write(num + " ");
            }

        }


        Console.ReadLine();     

        List<string> colors = new List<string>() { "Green", "Green", "Blue", "Orange", "Orange", "Purple", "Red", "Yellow" };

        Console.WriteLine();
        Console.WriteLine("Can you tell which colors are duplicated? \n Press ENTER to continue and reveal the answers.");
        Console.WriteLine();

        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        Console.WriteLine();
        Console.ReadLine();

        int cNum = 0;

        Console.WriteLine();
        foreach (string color in colors)
        {           
            int cNum1 = colors.IndexOf(color);
            if (cNum > cNum1)
            {
                Console.WriteLine("This " + color + " is a duplicate.");
            }
            else
            {
                Console.WriteLine(color);
            }
            cNum++;
        }

        Console.WriteLine();
        Console.WriteLine("Press ENTER to finish game.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Credits: David A. Simar: Game Design \n Thanks for playing!");
        Console.WriteLine("Press ENTER to continue.");
        Console.ReadLine();

        Console.WriteLine("Thank you for viewing my program. Have a good day.");
        Console.ReadLine();
    }
}