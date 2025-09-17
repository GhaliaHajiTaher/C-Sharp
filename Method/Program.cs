using System; // Required for basic system functions like Console

// Define a namespace to organize code; typically named after the project
namespace MathOperationApp
{
    // Create a class named MathHandler
    class MathHandler
    {
        // Define a void method that takes two integers
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first number (e.g., multiply it by 2)
            int result = num1 * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of the math operation on the first number: " + result);

            // Display the second number as requested
            Console.WriteLine("Second number passed to the method: " + num2);
        }
    }

    // Main class containing the entry point of the program
    class Program
    {
        // Entry point method where execution starts
        static void Main(string[] args)
        {
            // Instantiate the MathHandler class to access its methods
            MathHandler handler = new MathHandler();

            // Call the method using positional arguments
            // Pass in two integers: 5 and 10
            handler.PerformOperation(5, 10);

            // Call the method using named parameters
            // The order doesn't matter when using named parameters
            handler.PerformOperation(num2: 20, num1: 7);

            // Wait for user input before closing the console window (optional for debugging)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
