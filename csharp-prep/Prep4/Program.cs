using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        numbers.Add(18);

        Console.WriteLine(numbers.Count);

        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}