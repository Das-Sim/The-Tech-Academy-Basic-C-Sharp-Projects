using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Loops_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program is to demonstrate:");
            Console.WriteLine("A While Statement Loop");
            Console.WriteLine("A Do While Statement Loop");
            Console.WriteLine("");

            Console.WriteLine("Here is an example of a While Loop. The integer increases while it itself is below the number 13, as it will do below in the next 'Do While Loop'.");
            Console.WriteLine("");

            int n = 1;

            while (++n < 13)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("");

            Console.WriteLine("Here is an example of a Do While Loop. Do While Loops are great for avoiding bugs that will keep your loops from starting.");
            Console.WriteLine("");

            int i = 2;

            do
            {
                Console.WriteLine(i);
            } while (++i < 13);

            Console.WriteLine("");
            Console.WriteLine("END");

            Console.WriteLine("");
            Console.WriteLine("Thank you for viewing my program. Have a good day.");

            Console.ReadLine();

            //Do While Loops are to prevent errors; like the statement being overlooked completely when certain criteria are met

        }
    }
}
