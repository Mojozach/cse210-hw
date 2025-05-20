using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();
        string choice;
        string userInput;
        
        Console.WriteLine("\nWelcome to the Journal Program! ");
        entry.Inspire();
        
        do
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write: ");
            Console.WriteLine("2. Display: ");
            Console.WriteLine("3. Save: ");
            Console.WriteLine("4. Load: ");
            Console.WriteLine("5. Quit: ");
            Console.Write("What would you like to do?: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userInput = entry.CreateEntry();
                    journal.AddEntry(userInput);
                    break;
                case "2":
                    journal.PrintJournal();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Choice must be 1, 2, 3, 4, or 5.");
                    break;
            }
        } while (choice != "5");
     }
}