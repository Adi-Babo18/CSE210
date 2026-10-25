using System;
class Scripture
{
    public Scripture (string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);

        _words[7].Hide();
        // TODO
    }

    public Scripture (string bookName, int chapter, int startVerse, int endVerse, )
    {
        // TODO
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }
}