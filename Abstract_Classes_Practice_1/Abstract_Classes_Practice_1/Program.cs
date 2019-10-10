using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Inside the Main() method,    
            Employee temp = new Employee(); //- instantiate an Employee object with:
            temp.firstName = "Sample"; //- firstName "Sample"
            temp.lastName = "Student"; //- and lastName "Student".
            temp.SayName(); //- Call the SayName() method on the object.
            Console.ReadLine();
            IQuittable leave = new Employee(); //3a. Use polymorphism to create an object of type IQuittable. 
            leave.Quit(); //- Call the Quit() method on it.
        }
    }
}
