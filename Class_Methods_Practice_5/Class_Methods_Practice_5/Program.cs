using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 prac = new Class1(); //In the Main() method, instantiate that class.
            Console.WriteLine("Hello and Welcome to my program. Please Enter a Number."); //Have the user enter a number.   
            int input = Convert.ToInt32(Console.ReadLine());
            int result;
            prac.Num(input, out result); //Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.

            Console.WriteLine("Very good, my program has taken your number and divided it by two.\n Please press ENTER to continue.");
            Console.ReadLine();

            decimal dec;
            prac.Num(11.2m, out dec);
            //Console.WriteLine(dec);

            //Console.WriteLine(Class2.Num());
            Console.WriteLine("Thank you for viewing my program. Have a good day.");
            Console.ReadLine();
        }
    }
}
