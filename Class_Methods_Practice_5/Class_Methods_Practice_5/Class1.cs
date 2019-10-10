using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice_5
{
    //Create a class.  
    class Class1
    {
        public void Num(int num1, out int result) //Create a void method that outputs an integer.
        {
            result = (num1 / 2); //Have the method divide the data passed to it by 2.
            Console.WriteLine(result);
        }

        public void Num(decimal dec1, out decimal dec) //Overload a method.
        {
            decimal dec2 = 100.0m;
            decimal dSum = dec1 + dec2;
            dec = dec2 + dec1;
        }
    }
}
