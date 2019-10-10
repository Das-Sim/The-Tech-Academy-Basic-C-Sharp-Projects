using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Practice
{
    class Class1
    {
        //1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. 
        //The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

        //2. In the Main() program, ask the user what number they want to do the math operations on.

        //3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

        public int Sell(int input1)
        {
            int product1 = input1;
            int profit1 = 2 * (product1);
            return profit1;
        }

        public int Buy(int input2)
        {
            int cost1 = input2 - 25;
            return cost1;
        }
        public int Trade(int input3)
        {
            int trade1 = input3;
            return trade1;
        }
    }
}
