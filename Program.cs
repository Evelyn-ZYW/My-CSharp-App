using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        // strings and date are immutable by default, we cannot change them once they are instantiated
        // we can reassign the variable, we'll get the expected behaviour
        string name = "Evelyn";
        name = name.ToLower();
        Console.WriteLine(name);
        Console.WriteLine(DateTime.UtcNow);
        var date = DateTime.UtcNow.AddDays(1);
        Console.WriteLine(date);
    }
}