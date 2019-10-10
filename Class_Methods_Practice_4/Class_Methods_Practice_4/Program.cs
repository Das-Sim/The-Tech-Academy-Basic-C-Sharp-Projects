using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.
            Class1 prac = new Class1();

            //Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
            Console.WriteLine("Hello and Welcome to my Program!\n Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("You can enter a second number (default is 5). Press ENTER if you'd rather not enter the 2nd number: ");
            string txt = Console.ReadLine();
            if (Int32.TryParse(txt, out int txt2))
            {
                Console.WriteLine(prac.num(num1, txt2)); ////Call the method in the class, passing in the one or two numbers entered.
            }
            else
            {
                Console.WriteLine(prac.num(num1)); //Try various combinations of numbers on the code, including having no second number.
            }
            Console.ReadLine();

            Console.WriteLine("Thank you for viewing my program. Have a good day.");
            Console.ReadLine();
        }
    }
}
