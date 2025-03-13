using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        foreach (var e in Enum.GetValues(typeof(EmployeeType)))
        {
            Console.WriteLine(e);
        }
    }
}

enum EmployeeType
{
    manager = 1,
    supervisor = 2,
    worker = 3
}