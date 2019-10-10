using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Practice_1
{
    //3. Create another class called Employee. 
    public class Employee : Person //- Have it inherit from the Person class.
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);          
        }
    }
}
