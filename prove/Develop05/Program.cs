using System;
class Program
// TBD describe exceeds expectations
{
    static void Main()
    {
        bool running = true;
        int points = 0;

        Goals myGoals = new Goals();

        Console.Clear();
        while (running)
        {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal ");
            Console.WriteLine("2. List Goals ");
            Console.WriteLine("3. Save Goals ");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit ");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    myGoals.CreateGoal();
                    break;
                case "2":
                    myGoals.ListGoals();
                    break;
                case "3":
                    myGoals.SaveGoals();
                    break;
                case "4":
                    myGoals.LoadGoals();
                    break;
                case "5":
                    points = myGoals.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting the program.");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;

            }

        }
    }
}