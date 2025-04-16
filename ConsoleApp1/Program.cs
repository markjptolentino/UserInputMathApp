using System;

namespace UserInputMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiply user input by 50
            Console.WriteLine("Enter a number to multiply by 50:");
            string input1 = Console.ReadLine();
            long number1 = Convert.ToInt64(input1);
            long result1 = number1 * 50;
            Console.WriteLine("Result: " + result1);

            // Add 25
            Console.WriteLine("\nEnter a number to add 25:");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            int result2 = number2 + 25;
            Console.WriteLine("Result: " + result2);

            // Divide by 12.5
            Console.WriteLine("\nEnter a number to divide by 12.5:");
            string input3 = Console.ReadLine();
            double number3 = Convert.ToDouble(input3);
            double result3 = number3 / 12.5;
            Console.WriteLine("Result: " + result3);

            // Greater than 50 check
            Console.WriteLine("\nEnter a number to check if it's greater than 50:");
            string input4 = Console.ReadLine();
            int number4 = Convert.ToInt32(input4);
            bool isGreaterThan50 = number4 > 50;
            Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

            // Remainder after dividing by 7
            Console.WriteLine("\nEnter a number to find the remainder after dividing by 7:");
            string input5 = Console.ReadLine();
            int number5 = Convert.ToInt32(input5);
            int remainder = number5 % 7;
            Console.WriteLine("Remainder: " + remainder);

            // End of program
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
