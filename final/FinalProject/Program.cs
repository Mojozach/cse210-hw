using System;

class Program
{
    //public void RenderRoom(Room room) { }
    //public void ShowCombatOptions(Character character) { }
    //public void PromptInteraction(ObjectInteraction obj) { }

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
            Console.WriteLine($"You have selected: {selectedCharacter.Name}");
            Console.WriteLine($"Description: {selectedCharacter.Description}");
            selectedCharacter.ShowStats();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
}

