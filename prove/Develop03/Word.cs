using System;
using System.Collections.Generic;

class Word
{
    private List<bool> _isHidden;
    private int _numWordsHidden = 0;
    private int _totalWords;
    private static Random _random = new Random();

    public Word(List<string> words)
    {
        // Create a list of Boolean flags  = to the number of words with all initialized to false.
        _isHidden = new List<bool>(new bool[words.Count]);
        _totalWords = words.Count;

    }

    // This method hides a number of words and returns how many it hid.
    public int HideWords()
    {
        int timesHidden = 0;
        int randomNumber = 0;

        while ((timesHidden < 3) && (_numWordsHidden < _totalWords))
        {
            randomNumber = _random.Next(_totalWords);
            if (_isHidden[randomNumber] == false)
            {
                _isHidden[randomNumber] = true;
                _numWordsHidden += 1;
                timesHidden += 1;
            }
        }

        return (_numWordsHidden);
    }

    public bool IsHidden(int listIndex)
    {
        return _isHidden[listIndex];
    }
}