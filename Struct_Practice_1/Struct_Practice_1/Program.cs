using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Practice_1
{
    class Program
    {
        public struct Number //1a. Create a struct called Number.
        {
            public decimal Amount; //- Give it the property "Amount" and have it be of data type decimal.
        }
        static void Main(string[] args)
        {                    
            Number num1 = new Number(); //2a. In the Main() method, create an object of data type Number and assign an amount to it.
            num1.Amount = 19.19m;
            Console.WriteLine("Amount: " + num1.Amount); //3a.Print this amount to the console.
            Console.WriteLine("Thank you for viewing my program. Have a good day.");
            Console.Read();
        }
    }
    
}
