using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new Reference(bookName, chapter, verse);
        _words = ConvertToWordList(text);
        _random = new Random();
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWordList(text);
        _random = new Random();
    }

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> wordList = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            wordList.Add(word);
        }

        return wordList;
    }

    public void ShowScripture()
    {
        Console.WriteLine(_reference.GetReferenceString());

        foreach (Word word in _words)
        {
            word.Display();
            Console.Write(" ");
        }

        Console.WriteLine();
    }

    public void HideWords()
    {
        int wordsToHide = 3;

        for (int i = 0; i < wordsToHide; i++)
        {
            int visibleWords = 0;

            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    visibleWords++;
                }
            }

            if (visibleWords == 0)
            {
                return;
            }

            int randomNumber = _random.Next(visibleWords);

            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    if (randomNumber == 0)
                    {
                        word.Hide();
                        break;
                    }

                    randomNumber--;
                }
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}