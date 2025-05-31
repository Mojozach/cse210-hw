using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;



    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }
   
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void Display()
    {

        if (_startVerse == _endVerse)
            Console.Write($"{_book} {_chapter}:{_startVerse} ");
        else
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");       
    }
    
}