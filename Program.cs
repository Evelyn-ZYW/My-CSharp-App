using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int c = AddNumbers(a, b);
        Console.WriteLine(c);
        Console.WriteLine("Hello world!");
    }
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}