using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        var day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;

        }
    }
}

enum EmployeeType
{
    manager = 1,
    supervisor = 2,
    worker = 3
}