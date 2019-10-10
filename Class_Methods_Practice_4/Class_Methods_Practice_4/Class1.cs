using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice_4
{
    //Create a class.  
    class Class1
    {
        public int num(int num1, int num2 = 5) //Create a method that takes two integers as parameters. Make one of them optional.
        {
            Console.WriteLine(num1 + " plus " + num2 + " = "); //Have the method do a math operation and return an integer result.
            return (num1 + num2);
        }
    }
}
