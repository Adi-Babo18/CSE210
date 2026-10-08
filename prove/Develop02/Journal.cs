class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no Journal entries yet.");
            return;
        }

        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateJournalEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }
}