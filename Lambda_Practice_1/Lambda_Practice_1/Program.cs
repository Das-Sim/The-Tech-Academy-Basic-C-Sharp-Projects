using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. In the Main() method,  

            List<Employee> workList1 = new List<Employee>();

            //- Create a list of at least 10 employees.

            workList1.Add(new Employee("Joe", "Kalt", 1));
            workList1.Add(new Employee("Joe", "Presp", 2));
            workList1.Add(new Employee("Penny", "Loap", 3));
            workList1.Add(new Employee("Jean", "Davis", 4));
            workList1.Add(new Employee("Alex", "Baeler", 5));
            workList1.Add(new Employee("Jenna", "Wattsom", 6));
            workList1.Add(new Employee("Greg", "Eagles", 7));
            workList1.Add(new Employee("Kevin", "King", 8));
            workList1.Add(new Employee("Henry", "Noriss", 9));
            workList1.Add(new Employee("Peter", "Johnny", 10));

            //- Each employee should have a first and last name, as well as an Id.
            //- At least two employees should have the first name "Joe".

            //2. Create a new list of all employees with the first name "Joe".

            List<Employee> joeList1 = new List<Employee>();
            //- Using a foreach loop.

            foreach (Employee worker in workList1)
            {
                if (worker.FirstName == "Joe")
                {
                    joeList1.Add(worker);
                }
            }

           // 3. Do the same thing again, but this time with a lambda expression.

           List<Employee> newList1 = workList1.Where(x => x.FirstName == "Joe").ToList();

            // 4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> newList2 = workList1.Where(x => x.Id > 5).ToList();

            // Thank you for viewing my program. Have a good day. //
        }
    }
}
