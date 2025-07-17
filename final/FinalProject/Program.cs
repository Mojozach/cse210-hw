using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "RPG Character Selection";

        Character selectedCharacter = null;

        while (selectedCharacter == null)
        {
            Console.WriteLine("\nChoose your character class:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Elf");
            Console.WriteLine("3. Wizard");
            Console.Write("Enter the number of your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    selectedCharacter = new Warrior();
                    break;
                case "2":
                    selectedCharacter = new Elf();
                    break;
                case "3":
                    selectedCharacter = new Wizard();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.\n");
                    break;
            }
        }

        Console.Clear();
        Console.WriteLine($"You have selected: {selectedCharacter.GetName()}");
        Console.WriteLine($"Description: {selectedCharacter.GetDescription()}");
        selectedCharacter.ShowStats();

        Room chosenRoom = Room.SelectRoom();
        Console.WriteLine($"\nYou enter the {chosenRoom.GetName()}.\n{chosenRoom.GetDescription()}\n");

        if (chosenRoom.GetName() == "Fight Arena")
        {
            Enemy goblin = new Enemy("Goblin", 100, 60, 40);
            Combat.Battle(selectedCharacter, goblin);
        }
        else
        {
            Console.WriteLine("Nothing to fight here yet. Explore more rooms or come back later!");
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();

        Trap spikeTrap = new Trap("Spike Trap", 25); // Correct instantiation
        spikeTrap.Trigger();  // Triggers the trap
        spikeTrap.Reset();    // Resets the trap
        spikeTrap.Trigger();  // Triggers again
    }
}
