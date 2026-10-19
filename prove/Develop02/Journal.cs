using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no Journal entries yet.");
        }
        else
        {
            foreach (JournalEntry entry in _entries)
            {
                entry.DisplayJournalEntry();
            }
        }
    }

    public void CreateJournalEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }

    public void SaveToFile()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in _entries)
            {
                file.WriteLine(entry.GetFileLine());
            }
        }

        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                JournalEntry entry = new JournalEntry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                _entries.Add(entry);
            }

            Console.WriteLine("Journal loaded.");
        }
        else
        {
            Console.WriteLine("The file was not found.");
        }
    }
}