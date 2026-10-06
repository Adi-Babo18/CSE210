using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 6;
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess < magicNumber)
            {
                Console.WriteLine("The magic number is higher.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("The magic number is lower.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}