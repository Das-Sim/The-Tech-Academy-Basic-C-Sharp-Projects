using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Practice_1
{
    //3. Create another class called Employee. 
    public class Employee : Person//, IQuittable //- Have it inherit from the Person class. //2a. Have your Employee class from the previous drill inherit IQuittable. 
    {
        public int ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);

        }
        public static bool operator ==(Employee ID1, Employee ID2) //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. 
        {
            return ID1.ID.Equals(ID2.ID);
        }

        public static bool operator !=(Employee ID1, Employee ID2) //Overload the "!=" operator so it checks if two Employee objects are equal by comparing their Id property. 
        {
            return !ID1.ID.Equals(ID2.ID);
        }

    }

    //public void Quit() //- Implement the Quit() method in any way you choose.
}
