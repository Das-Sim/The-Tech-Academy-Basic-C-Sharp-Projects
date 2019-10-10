using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Practice_3
{
    //1. Create a class.  
    
    class Class1
    {
        public int num(int num1) //In that class, create a method that will take in an integer,
        {
            int result = (num1 + 5); ////do a math operation to it and then return the answer as an integer.
            return num1;
        }

        public decimal num(decimal num1) //3. Add a second method to the class, with the same name, that will take in a decimal 
        {
            decimal result1 = (num1 * 5); //do a different math operation to it and then return the answer as an integer.
            return num1;
        }

        public int num(string str1) //5. Add a third method to the class, with the same name, that will take in a string
        {
            int prac;
            int.TryParse(str1, out prac); //convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.
            return prac / 5;
        }
    }
}
