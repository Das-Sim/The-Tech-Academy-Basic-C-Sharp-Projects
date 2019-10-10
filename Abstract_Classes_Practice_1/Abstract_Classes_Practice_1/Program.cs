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
            Employee temp1 = new Employee();
            temp.firstName = "Sample"; //- firstName "Sample"
            temp.lastName = "Student"; //- and lastName "Student".
            temp.ID = 1;
            temp1.ID = 2;
            temp.SayName(); //- Call the SayName() method on the object.
            if(temp.ID == temp1.ID)
            {
                Console.WriteLine("ID's are matching."); //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. 
            }
            else
            {
                Console.WriteLine("No matching ID's were found."); //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
            }
            Console.ReadLine();
            //IQuittable leave = new Employee(); //3a. Use polymorphism to create an object of type IQuittable. 
            //leave.Quit(); //- Call the Quit() method on it.          
            
        }
    }
}
