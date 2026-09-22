using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter you first name: ");
        string first = Console.ReadLine();

        Console.WriteLine("Enter your last name: ");
        string last = Console.ReadLine();

        Console.WriteLine($"Hello {first} {last}.");
    }
}