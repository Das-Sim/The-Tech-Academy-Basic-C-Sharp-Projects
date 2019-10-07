using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to my example of String Concatination in C#! \n Press ENTER to continue to the program.");
            Console.ReadLine();

            string name = "Dan ";
            string mname = "The ";
            string lname = "Man";
            Console.WriteLine(name);
            Console.WriteLine(mname);
            Console.WriteLine(lname);

            Console.WriteLine();
            Console.WriteLine("Here we have made 3 strings. \n Please press ENTER.");
            Console.ReadLine();

            string answer = name + mname + lname;

            answer = answer.ToUpper();

            Console.WriteLine(answer);

            Console.WriteLine();
            Console.WriteLine("Here we take 3 seperate strings, concatinate them, change the strings to uppercase, and form a person's whole name!");
            Console.WriteLine("Please press ENTER.");
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Dan! ");
            sb.Append("My middle name is The! ");
            sb.Append("My last name is Man!");
            Console.WriteLine();

            Console.WriteLine("Using StringBuilder we can change strings without performance loss when dealing with large projects");

            Console.WriteLine();
            Console.WriteLine(sb);
            Console.WriteLine();
            Console.WriteLine("Please press ENTER.");
            Console.ReadLine();

            Console.WriteLine("Thank you for using my program, Have a good day!");
            Console.ReadLine();


        }
    }
}
