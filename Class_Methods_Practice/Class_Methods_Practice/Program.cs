using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();
            Console.WriteLine("Hello traveller, welcome to my shop.\n Here you can BUY, SELL, or TRADE your hard earned loot.\n Let's get started. Press ENTER to continue.");
            Console.ReadLine();

            Console.WriteLine("Enter how many wooden logs you would like to sell.\n");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int result1 = math.Sell(input1);
            Console.WriteLine(result1 + " gold earned.\n");

            Console.WriteLine("Enter how many potions you would like to buy.\n");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result2 = math.Buy(input2);
            Console.WriteLine(result2 + " gold owed.\n");

            Console.WriteLine("Enter how many apples you like to trade.\n");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int result3 = math.Trade(input3);
            Console.WriteLine(result3 + " oranges recieved. Trade complete.\n Thanks for stopping by the shop.\n Press ENTER to continue.");
            Console.ReadLine();

            Console.WriteLine("Thank you for viewing my program. Have a good day.");
            Console.ReadLine();
        }
    }
}
