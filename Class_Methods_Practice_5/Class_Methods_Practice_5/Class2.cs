using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice_5
{
    //Declare a class to be static.
    static class Class2
    {
        //Create a method with output parameters.
        public static string text1;
        public static string Num()
        {
            text1 = "Hello World!";
            return text1;
        }
    }
}
