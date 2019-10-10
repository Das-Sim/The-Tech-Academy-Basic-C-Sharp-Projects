using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.In the Main() method of the console app            
            Class1 prac = new Class1(); //instantiate the class          
            Console.WriteLine(prac.num(12)); //call the one method, passing in an integer, such as 12. Then display the result to the screen.
            Console.WriteLine(prac.num(100.00m)); //call the second method, passing in a decimal. Display the result to the screen.
            Console.WriteLine(prac.num(112)); //call the third method, passing in a string that equates to an integer. Display the result to the screen.
            Console.ReadLine();


        }
    }
}
