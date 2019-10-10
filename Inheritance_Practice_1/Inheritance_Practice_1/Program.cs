using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Inside of the Main method,   
            Employee temp = new Employee(); //- instantiate and initialize an Employee object with

            temp.FirstName = "Sample"; //- a first name of "Sample"
            temp.LastName = "Student"; //- and a last name of "Student".

            temp.SayName(); //5. Call the superclass method SayName() on the Employee object.
            Console.WriteLine("Thank you for viewing my program. Have a good day.");
            Console.ReadLine();
        }
    }
}
