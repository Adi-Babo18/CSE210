using System;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine();
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        string[] prompts =
        {
            "How was your day?",
            "Talk about someone you met.",
            "What was the best part of your day?",
            "What are you thankful for?",
            "What did you learn today?",
            "What goal did you work on today?"
        };

        Random random = new Random();
        int number = random.Next(prompts.Length);
        _date = DateTime.Now.ToString();
        _prompt = prompts[number];

        Console.WriteLine(_prompt);
        Console.Write("Response: ");
        _response = Console.ReadLine();
    }

    public string GetFileLine()
    {
        return _date + "|" + _prompt + "|" + _response;
    }
}