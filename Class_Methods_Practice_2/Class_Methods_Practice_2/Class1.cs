using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice_2
{
    //Create a class. In that class,
    class Class1
    {
        public void num(int num1, int num2) //create a void method that takes two integers as parameters. 
        {  
            int result = num1 * 42; //Have the method do a math operation on the first integer and display the second integer to the screen.
            Console.WriteLine(result);
            Console.WriteLine(num2 + " was the second number.");//Call the method in the class, specifying the parameters by name.
        }
    }
}
