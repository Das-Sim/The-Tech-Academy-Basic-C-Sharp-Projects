using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 prac = new Class1(); //In the Main() method of the console app, instantiate the class.
            prac.num(4, 2); //Call the method in the class, passing in two numbers.         
            Console.ReadLine();
        }
    }
}
