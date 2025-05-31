using System;
using System.Collections.Generic;

class Scripture
{
    private int _wordCount;
    private int _hiddenWordCount = 0;
    private bool _firstTime = true;

    private List<string> _words;
    private Word myWord;

    // Constructor for Scripture Class
    public Scripture(string textInput)
    {
        _words = new List<string>(textInput.Split(' '));
        _wordCount = _words.Count;
        // Send scripture to words
        myWord = new Word(_words);
    }

    // Displays the scripture, after the first display it starts calling Word class to create blanks and display with some words
    // blanked out.
    public bool Display()
    {
        if (_firstTime)
        {
            Console.WriteLine(string.Join(" ", _words));
            _firstTime = false;
        }
        else
        {
            _hiddenWordCount = myWord.HideWords();
            for (int i = 0; i < _words.Count; i++)
            {
                if (myWord.IsHidden(i))
                    Console.Write($"_____  ");
                else
                    Console.Write($"{_words[i]} ");
            }
        }
        return (_hiddenWordCount == _words.Count);
    }

    // Allows the user to input a new scripture to learn
    public void UserInputScripture()
    {
        Console.WriteLine("What is the new scripture? ");
        string newScript = Console.ReadLine();
        _words = new List<string>(newScript.Split(' '));
        _wordCount = _words.Count;
        // Send scripture to words
        myWord = new Word(_words);
    }
}