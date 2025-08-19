using System;

class Program
{
    static void Main()
    {
        // Greet the user and set the tone for what comes next
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask for the weight of the package
        Console.WriteLine("Please enter the package weight:");
        string weightInput = Console.ReadLine(); // Capture user's input as a string
        double packageWeight = Convert.ToDouble(weightInput); // Convert string input into a usable number

        // If the package weighs too much, we’re not shipping it — end of story
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit early since the weight doesn't meet requirements
        }

        // Gather the package's width
        Console.WriteLine("Please enter the package width:");
        string widthInput = Console.ReadLine();
        double packageWidth = Convert.ToDouble(widthInput); // Convert to number for calculations

        // Ask for how tall the package is
        Console.WriteLine("Please enter the package height:");
        string heightInput = Console.ReadLine();
        double packageHeight = Convert.ToDouble(heightInput);

        // Lastly, get how long the package is
        Console.WriteLine("Please enter the package length:");
        string lengthInput = Console.ReadLine();
        double packageLength = Convert.ToDouble(lengthInput);

        // Add up the dimensions to check if the package is too bulky
        double dimensionTotal = packageWidth + packageHeight + packageLength;

        // If it's too big overall, we can't ship it — rules are rules
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Cut it off here if the package is oversized
        }

        // Here's the magic: volume * weight ÷ 100 gives us the shipping cost
        double quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

        // Show the final shipping estimate, neatly formatted to two decimal places
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        
        // Sign off with appreciation
        Console.WriteLine("Thank you!");
    }
}
