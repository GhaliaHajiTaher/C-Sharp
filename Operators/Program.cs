using System; // Provides basic system functionality like Console input/output

// Define the Employee class
class Employee
{
    // Auto-implemented property for employee Id
    public int Id { get; set; }

    // Auto-implemented property for employee's first name
    public string FirstName { get; set; }

    // Auto-implemented property for employee's last name
    public string LastName { get; set; }

    // Overload the '==' operator to compare two Employee objects by their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check for null on both sides to avoid NullReferenceException
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;

        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Return true if their Ids are equal
        return emp1.Id == emp2.Id;
    }

    // Overload the '!=' operator - required as operators must be overloaded in pairs
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return the inverse of the == operator
        return !(emp1 == emp2);
    }

    // Override Equals to be consistent with '==' operator (recommended)
    public override bool Equals(object obj)
    {
        // Try to cast the object to Employee
        Employee other = obj as Employee;

        if (other == null)
            return false;

        // Compare by Id
        return this.Id == other.Id;
    }

    // Override GetHashCode to be consistent with Equals
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}

// Main class where program execution begins
class Program
{
    static void Main(string[] args)
    {
        // Create first Employee object and assign values
        Employee emp1 = new Employee();
        emp1.Id = 101;
        emp1.FirstName = "Ghalia";
        emp1.LastName = "HajiTaher";

        // Create second Employee object and assign values
        Employee emp2 = new Employee();
        emp2.Id = 101; // Same Id as emp1 to test equality
        emp2.FirstName = "test";
        emp2.LastName = "test";

        // Compare the two employees using the overloaded '==' operator
        bool areEqual = emp1 == emp2;

        // Output the result of the comparison
        Console.WriteLine("Are emp1 and emp2 equal (by Id)? " + areEqual);

        // Also demonstrate the '!=' operator
        bool areNotEqual = emp1 != emp2;
        Console.WriteLine("Are emp1 and emp2 NOT equal (by Id)? " + areNotEqual);

        // Pause the console so the user can see the output
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
