using System;
    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            Console.WriteLine("Pick a number. ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number. ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diving the two...");
            int num3 = num1 / num2;
            Console.WriteLine(num1 + " divided by " + num2 + " equals " + num3);
            Console.ReadLine();
        }

        catch (FormatException ex)
        {
            Console.WriteLine("Please provide a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please no dividing by zero here.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }   
        
        }
    }
