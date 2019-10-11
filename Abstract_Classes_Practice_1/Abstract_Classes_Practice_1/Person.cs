using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Practice_1
{
    //1. Create an abstract class called Person with two properties:
    public abstract class Person
    {
        public string firstName { get; set; } //- string firstName
        public string lastName { get; set; } //- and string lastName.

        //public abstract void SayName();  //- 2. Give it the method SayName().            
    }
}
