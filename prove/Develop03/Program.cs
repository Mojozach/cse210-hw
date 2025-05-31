using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        bool allWordsHidden = false;

        Reference myRef = new Reference("Mosiah", 2, 21);
        Scripture script = new Scripture("I say unto you that if ye should serve him who has created you from the beginning and is perserving you from day to day, by lending your ");

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