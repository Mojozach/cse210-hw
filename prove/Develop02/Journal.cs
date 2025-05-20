using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Journal
{
    private string _fileName;
    private List<string> _entries = new List<string>();

    // Constructor
    public Journal()
    {
    }
    public void PrintJournal()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry); 
        }
    }
    public void LoadJournal()
     {
        Console.Write("What is the name of the file you would like to load? ");
        _fileName = Console.ReadLine();

        if (File.Exists(_fileName))
        {
            string[] lines = File.ReadAllLines(_fileName);

            foreach (string line in lines)
            {
               _entries.Add(line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void SaveJournal()
    {
      Console.Write("What would you like to name the file?");
        _fileName = Console.ReadLine();

      using (StreamWriter outputFile = new StreamWriter(_fileName))
      {
          foreach (string entry in _entries)
          {
              outputFile.WriteLine(entry); 
          }        
      }
    
      Console.WriteLine("You have saved your Journal! ");
    }
    public void AddEntry(string text)
    {
        _entries.Add(text);
    }
}
