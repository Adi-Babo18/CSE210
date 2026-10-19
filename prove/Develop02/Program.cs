using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();
        int response = 0;
        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            if (response == 1)
            {
                myJournal.CreateJournalEntry();
            }
            else if (response == 2)
            {
                myJournal.DisplayJournal();
            }
            else if (response == 3)
            {
                myJournal.SaveToFile();
            }
            else if (response == 4)
            {
                myJournal.LoadFromFile();
            }
            else if (response == 5)
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}