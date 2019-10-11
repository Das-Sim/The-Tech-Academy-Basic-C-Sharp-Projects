using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Practice_1
{
    //3. Create another class called Employee. 
    public class Employee<T> : Person//, IQuittable //- Have it inherit from the Person class. //2a. Have your Employee class from the previous drill inherit IQuittable. //1b. Make the Employee class take a generic type parameter.
    {
        public int ID { get; set; }
        public List<T> things { get; set; } //2b. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
        //public override void SayName()
        //{
        //    Console.WriteLine(firstName + " " + lastName);

        //}
        //public static bool operator ==(Employee ID1, Employee ID2) //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. 
        //{
        //    return ID1.ID.Equals(ID2.ID);
        //}

        //public static bool operator !=(Employee ID1, Employee ID2) //Overload the "!=" operator so it checks if two Employee objects are equal by comparing their Id property. 
        //{
        //    return !ID1.ID.Equals(ID2.ID);
        //}

    }

    //public void Quit() //- Implement the Quit() method in any way you choose.
}
