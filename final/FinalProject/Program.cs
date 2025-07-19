using System;

// My main classes are characters, combat, room and traps.
// My subclasses are elf, wizard, warrior and enemy of the base character class
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("RPG Character Selection");

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
            Enemy minotaur = new Enemy("Minotaur", 500, 60, 40);
            Trap spikeTrap = new Trap("Spike Trap", 25);
            spikeTrap.Trigger();  // Triggers the trap
            selectedCharacter.TakeDamage(spikeTrap.GetDamage());
            Combat.Battle(selectedCharacter, minotaur);
        }
        else if (chosenRoom.GetName() == "Training Grounds")
        {
            Enemy goblin = new Enemy("Goblin", 30, 20, 10);
            Combat.Battle(selectedCharacter, goblin);
        }
        else
        {
            Console.WriteLine("You spend a week reading books and learning arcane magic.");
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
