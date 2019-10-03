using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Compare_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate? ");
            decimal hRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Hours worked per week? ");
            decimal hWork = decimal.Parse(Console.ReadLine());         

            decimal salary = hRate * hWork;

            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate? ");
            decimal hRate2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Hours worked per week? ");
            decimal hWork2 = decimal.Parse(Console.ReadLine());

            decimal salary2 = hRate2 * hWork2;

         

            Console.WriteLine("Weekly salary of Person 1: " + salary);
            Console.WriteLine("Weekly salary of Person 2: " + salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?: " + (salary > salary2));
            Console.WriteLine("Have a good day!");
            Console.ReadLine();

        }
    }
}
