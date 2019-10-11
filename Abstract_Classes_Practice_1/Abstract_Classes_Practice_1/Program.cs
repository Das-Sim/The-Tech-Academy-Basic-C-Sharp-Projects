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
            Employee<string> newEmp1 = new Employee<string>(); //3b. Instantiate an Employee object with type "string" as its generic parameter.
            newEmp1.things = new List<string>(); //- Assign a list of strings as the property value of Things.
            newEmp1.things.Add("Tomas");
            newEmp1.things.Add("Ace");
            newEmp1.things.Add("Every");
            newEmp1.things.Add("Joane");
            newEmp1.things.Add("Billy");

            Employee<int> newEmp2 = new Employee<int>(); //4b. Instantiate an Employee object with type "int" as its generic parameter. 
            newEmp2.things = new List<int>(); //- Assign a list of integers as the property value of Things.
            newEmp2.things.Add(32);
            newEmp2.things.Add(23);
            newEmp2.things.Add(12);
            newEmp2.things.Add(21);
            newEmp2.things.Add(45);

            // 5.Create a loop that prints all of the Things to the Console.

            Console.WriteLine("Here are the Employees!\n");
            foreach (string str in newEmp1.things) { Console.WriteLine(str); }
            Console.WriteLine("\nHere are their ID's!\n");
            foreach (int num in newEmp2.things) { Console.WriteLine(num); }

            Console.Read();

            //Employee temp = new Employee(); //- instantiate an Employee object with:
            //Employee temp1 = new Employee();
            //temp.firstName = "Sample"; //- firstName "Sample"
            //temp.lastName = "Student"; //- and lastName "Student".
            //temp.ID = 1;
            //temp1.ID = 2;
            //temp.SayName(); //- Call the SayName() method on the object.
            //if(temp.ID == temp1.ID)
            //{
            //    Console.WriteLine("ID's are matching."); //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. 
            //}
            //else
            //{
            //    Console.WriteLine("No matching ID's were found."); //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
            //}
            //Console.ReadLine();
            //IQuittable leave = new Employee(); //3a. Use polymorphism to create an object of type IQuittable. 
            //leave.Quit(); //- Call the Quit() method on it.          

        }
    }
}
