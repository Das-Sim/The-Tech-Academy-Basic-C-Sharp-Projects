using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_1
{
    //1. Create a class called Person, 
    public class Person
    {
        //- Give it two properties, each of data type string.
        public string FirstName { get; set; } //- One called FirstName
        public string LastName { get; set; } //- The other LastName.

        public void SayName() //2. Give this class a void method called SayName() that takes no parameters and simply, 
        {
            Console.WriteLine(string.Concat("Name: " + FirstName + " " + LastName)); //- writes the person's full name to the console in the format of: "Name: [full name]".

        }
    }

    
}
