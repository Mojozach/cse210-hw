using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        bool allWordsHidden = false;

        Reference myRef = new Reference("Isaiah", 40, 31);
        Scripture script = new Scripture("But they that wait upon the Lord shall renew their strength, they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint.");

        Console.WriteLine("Would you like to enter a new scripture? (y/n)");
        string newInput = Console.ReadLine();
        if (newInput == "y")
        {
            myRef.UserInputReference();
            script.UserInputScripture();
        }
        
        do
        {
            Console.Clear();
            myRef.Display();
            allWordsHidden = script.Display();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

        } while ((userInput != "quit") && (allWordsHidden != true)); 
    }
}