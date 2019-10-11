using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Practice_1
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public Employee(string FirstName, string LastName, int Id) : base(FirstName, LastName)
        {
            this.Id = Id;
        }
    }
}
