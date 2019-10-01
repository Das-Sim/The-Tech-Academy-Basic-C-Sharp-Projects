using System;

namespace Daily_Report
{
    class Program
    {
        private static string GetConsoleString(string question, string requestion)
        {
            Console.WriteLine(question);
            string result = Console.ReadLine();
            while (string.IsNullOrEmpty(result))
            {
                Console.WriteLine(requestion);
                result = Console.ReadLine();
            }
            return result;
        }
        
        private static int GetConsoleInt(string question, string requestion)
        {
            int result;
            Console.WriteLine(question);
            string intIn = Console.ReadLine();
            while (!int.TryParse(intIn, out result))
            {
                Console.WriteLine(requestion);
                intIn = Console.ReadLine();
            }
            return result;
        }
        
        private static bool GetConsoleBool(string question, string requestion)
        {
            bool result;
            Console.WriteLine(question);
            string helpNeeded = Console.ReadLine();
            while (!Boolean.TryParse(helpNeeded, out result))
            {
                Console.WriteLine(requestion);
                helpNeeded = Console.ReadLine();
            }
            return result;
        }

        static void Main(string[] args)
        {         
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n\n");

            string courseName = GetConsoleString("What course are you on?",
                "Cannot be blank, please enter N/A to move on."
                );

            int pageNumber = GetConsoleInt("What page number?", "Must be an integer..");

            bool needHelp = GetConsoleBool("Do you need help with anything? Please answer “True” or “False”.",
                "Cannot be blank, please enter either “True” or “False”."
                );

            string posExperiences = GetConsoleString("Were there any positive experiences you’d like to share? Please give specifics.",
                "Cannot be blank, please enter N/A."
                );

            string feedback = GetConsoleString("Is there any other feedback you’d like to provide? Please be specific.",
                "Cannot be blank, please enter N/A."
                );

            int hoursStudied = GetConsoleInt("How many hours did you study today?", 
                "Must be an integer.."
                );

            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}