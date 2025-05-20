using System;

class Entry
{
    private string _text;
    private string _date;
    private string _journalEntry;
    List<string> _prompt = new List<string>
    {
       "Who was the most interesting person I interacted with today? ",
       "What was the best part of my day? ",
       "How did I see the hand of the Lord in my life today? ",
       "What was the strongest emotion I felt today? ",
       "If I had one thing I could do over today, what would it be? ",
       "What did you read in the scriptures today? ",
       "How did you help someone today? "
    };

    List<string> _inspoThought = new List<string>
    {
       "Those who keep a personal journal are more likely to keep the Lord in remembrance in their daily lives. Pres. Kimball",
       "Sometimes God doesn't remove us from the storm, but He does walk us through it.",
       "We can turn from the paths that would lead us down and, with a song in our hearts, follow a star and walk toward the light.",
       "Faith is not so much something we believe; faith is something we live.  Elder Wirthlin",
       "If  you're serious about sanctification, you can expect to experience heart-wrenching moments that try your faith, your endurance and your patience.  Sis. Dew",
       "And then, if thou endure it well, God shall exalt thee on high.",
       "God not only loves the obedient - He enlightens them. Pres Eyring"
    };

    public Entry()
    {

    }
    public string CreateEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        string randomPrompt = _prompt[index];
        Console.WriteLine($"{randomPrompt}");
        _text = Console.ReadLine();
        _date = DateTime.Today.ToString("MM/dd/yyyy");
        _journalEntry = ($"{_date}, | {randomPrompt}: {_text}");
        return (_journalEntry);
    }

    public void Inspire()
    {
        Random random = new Random();
        int index = random.Next(_inspoThought.Count);
        string randomInspo = _inspoThought[index];
        Console.WriteLine($"{randomInspo}");
    }
}

  

