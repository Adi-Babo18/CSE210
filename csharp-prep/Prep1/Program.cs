using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        if (percent >= 95)
        {
            letter = "A";
        }
        else if (percent >= 90)
        {
            letter = "A-";
        }
        else if (percent >= 88)
        {
            letter = "B+";
        }
        else if (percent >= 85)
        {
            letter = "B";
        }
        else if (percent >= 80)
        {
            letter = "B-";
        }
        else if (percent >= 78)
        {
            letter = "C+";
        }
        else if (percent >= 75)
        {
            letter = "C";
        }
        else if (percent >= 70)
        {
            letter = "C-";
        }
        else if (percent >= 68)
        {
            letter = "D+";
        }
        else if (percent >= 65)
        {
            letter = "D";
        }
        else if (percent >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade on average is: {letter} ");

        if (percent >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}