using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        // for loop
        // for (var i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // while loop
        // var i = 0;
        // while (i != 5)
        // {
        //     i++;
        //     Console.WriteLine(i);
        // }

        //foreach
        int[] intArr = [1, 2, 3, 4, 5];
        foreach (var value in intArr)
        {
            Console.WriteLine(value);
        }
    }
}

enum EmployeeType
{
    manager = 1,
    supervisor = 2,
    worker = 3
}