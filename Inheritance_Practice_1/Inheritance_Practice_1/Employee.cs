using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_1
{
    // 3. Create another class called Employee.  
    public class Employee : Person //- have it inherit from the Person class.
    {
        public int Id { get; set; } //- Give the Employee class a property called Id and have it be of data type int.
    }
}
