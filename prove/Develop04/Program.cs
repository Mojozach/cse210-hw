using System;
class Program
//Made it so for prompt2 in reflection. It doesn't repeat questions till all questions been answered.
{
    static void Main()
    {
        bool running = true;
        Breathing myBreath = new Breathing();
        Listing myListing = new Listing();
        Reflection myReflection = new Reflection();

        Console.Clear();
        while (running)
        {
            Console.WriteLine("=== Menu Options: === ");
            Console.WriteLine("1. Start breathing activity ");
            Console.WriteLine("2. Start reflecting activity ");
            Console.WriteLine("3. Start listing activity ");
            Console.WriteLine("4. Quit ");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    myBreath.PerformActivity();
                    break;
                case "2":
                    myReflection.PerformActivity();
                    break;
                case "3":
                    myListing.PerformActivity();
                    break;
                case "4":
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