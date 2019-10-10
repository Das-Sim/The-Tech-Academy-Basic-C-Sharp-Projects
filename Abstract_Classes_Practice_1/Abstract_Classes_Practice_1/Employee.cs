using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Practice_1
{
    //3. Create another class called Employee. 
    public class Employee : Person, IQuittable //- Have it inherit from the Person class. //2a. Have your Employee class from the previous drill inherit IQuittable. 
    {
        public override void SayName()
        {
            Console.WriteLine();
            Console.WriteLine(firstName + " " + lastName);          
        }
        public void Quit() //- Implement the Quit() method in any way you choose.
        {

        }
    }
}
