using System;
class Program
// For exceeds expectations, I have added a leveling up system to help motivate the user.
{
    static void Main()
    {
        bool running = true;
        Goals myGoals = new Goals();

        Console.Clear();
        while (running)
        {
            Console.WriteLine($"You have {myGoals.GetPoints()} points.");
            PrintTitle();
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
                    myGoals.RecordEvent();
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
        void PrintTitle()
        {
            int totalPoints = myGoals.GetPoints();

            if (totalPoints < 100)
                Console.WriteLine("Unfortunately, you are a slacker.");
            else if (totalPoints < 150)
                Console.WriteLine("You are a poor lowly peasant.");
            else if (totalPoints < 250)
                Console.WriteLine("You are now a majestic Knight.");
            else if (totalPoints < 450)
                Console.WriteLine("What is better than a Royal Knight?");
            else if (totalPoints < 500)
                Console.WriteLine("You are a vicious Baron.");
            else if (totalPoints < 750)
                Console.WriteLine("You are now a regal Earl.");
            else if (totalPoints < 1000)
                Console.WriteLine("The world is graced by your presence majestic Duke.");
            else if (totalPoints < 1500)
                Console.WriteLine("You are a saintly Prince.");
            else if (totalPoints < 2000)
                Console.WriteLine("You are a noble and wise King.");
            else
                Console.WriteLine("You are a terrifying and all knowing Wizard.");
        }
    }
}