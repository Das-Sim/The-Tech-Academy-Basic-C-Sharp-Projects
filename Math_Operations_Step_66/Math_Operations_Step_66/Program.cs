using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations_Step_66
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num = num1 * 50;

            Console.WriteLine(num);
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            

            Console.WriteLine("Enter 2nd number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num = num1 + 25;

            Console.WriteLine(num);
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();

            Console.WriteLine("Enter 3rd number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToDouble(num);
            num2 = num1 / 12.5;

            Console.WriteLine(num2);
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();

            Console.WriteLine("Enter 4th number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            int num3 = 50;
            bool isGreater = num1 > num3;
            
            Console.WriteLine(isGreater);
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();

            Console.WriteLine("Enter 5th number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num = num1 % 7;

            Console.WriteLine(num);
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            
        }
    }
}