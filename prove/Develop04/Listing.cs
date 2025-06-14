using System;
using System.Collections.Generic;

class Word
{
    private List<bool> _isHidden;
    private int _numWordsHidden = 0;
    private int _totalWords;
    private static Random _random = new Random();

    // Constructor for Word Class
    public Word(List<string> words)
    {
        // Create a list of Boolean flags  = to the number of words with all initialized to false.
        _isHidden = new List<bool>(new bool[words.Count]);
        _totalWords = words.Count;

    }
}