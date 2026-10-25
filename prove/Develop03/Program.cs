using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Creativity and exceeding requirements:
        My program hides three words at a time.
        It also only chooses words that are still visible,
        so it does not randomly hide the same word twice.
        */

        Scripture myScripture = new Scripture(
            "Moses",
            1,
            39,
            "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man."
        );

        while (!myScripture.IsCompletelyHidden())
        {
            Console.Clear();

            myScripture.ShowScripture();

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type quit.");

            string answer = Console.ReadLine();

            if (answer.ToLower() == "quit")
            {
                break;
            }

            myScripture.HideWords();
        }

        Console.Clear();
        myScripture.ShowScripture();

        Console.WriteLine();
        Console.WriteLine("The program is finished.");
    }
}