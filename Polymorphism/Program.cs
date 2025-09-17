using System; // Provides basic system functionality like Console

// Define an interface named IQuittable
interface IQuittable
{
    // Define a void method signature that must be implemented by any class that implements this interface
    void Quit();
}

// Define the Employee class that implements the IQuittable interface
class Employee : IQuittable
{
    // Property for employee ID
    public int Id { get; set; }

    // Property for employee's first name
    public string FirstName { get; set; }

    // Property for employee's last name
    public string LastName { get; set; }

    // Implement the Quit() method from IQuittable interface
    public void Quit()
    {
        // Display a message to the console indicating the employee has quit
        Console.WriteLine($"Employee {FirstName} {LastName} (ID: {Id}) has quit.");
    }
}

// Main class where program execution starts
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee and assign values to its properties
        Employee emp = new Employee
        {
            Id = 202,
            FirstName = "Ghalia",
            LastName = "HajiTaher"
        };

        // Use polymorphism: create an object of type IQuittable, assign it the Employee instance
        IQuittable quittable = emp;

        // Call the Quit() method on the IQuittable object
        // This will execute the Employee's implementation of Quit()
        quittable.Quit();

        // Pause the console window so the user can read the output
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
