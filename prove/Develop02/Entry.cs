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
    "If I had one thing I could do over today, what would it be? "
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
}

  

