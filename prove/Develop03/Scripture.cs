using System;
using System.Collections.Generic;

class Scripture
{
    private int _wordCount;
    private int _hiddenWordCount = 0;
    private bool _firstTime = true;

    private List<string> _words;
    private Word myWord;

    public Scripture(string textInput)
    {
        _words = new List<string>(textInput.Split(' '));
        _wordCount = _words.Count;
        // Send scripture to words
        myWord = new Word(_words);
    }

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

}