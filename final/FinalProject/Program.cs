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
        Room chosenRoom = Room.SelectRoom();
        Console.WriteLine($"\nYou enter the {chosenRoom.Name}.\n{chosenRoom.Description}\n");

       if (chosenRoom.Name == "Fight Arena")
       {
        Enemy goblin = new Enemy("Goblin", 100, 60, 40);
        Battle(selectedCharacter, goblin);
       }
       else
       {
        Console.WriteLine("Nothing to fight here yet. Explore more rooms or come back later!");
       }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
    
    static void Battle(Character player, Enemy enemy)
    {
        Console.WriteLine($"\nBattle Start: {player.Name} VS {enemy.Name}!");
        Console.WriteLine($"{player.Name} HP: {player.HP} | {enemy.Name} HP: {enemy.HP}\n");

        while (player.HP > 0 && enemy.HP > 0)
        {
            // Player attacks first
            int damageToEnemy = Math.Max(player.Attack - enemy.Defense, 0);
            enemy.HP -= damageToEnemy;
            Console.WriteLine($"{player.Name} attacks and deals {damageToEnemy} damage! {enemy.Name} HP left: {Math.Max(enemy.HP, 0)}");

            if (enemy.HP <= 0)
            {
                Console.WriteLine($"\n{enemy.Name} is defeated! You win!");
                break;
            }

            // Enemy attacks back
            int damageToPlayer = Math.Max(enemy.Attack - player.Defense, 0);
            player.HP -= damageToPlayer;
            Console.WriteLine($"{enemy.Name} attacks and deals {damageToPlayer} damage! {player.Name} HP left: {Math.Max(player.HP, 0)}");

            if (player.HP <= 0)
            {
                Console.WriteLine($"\n{player.Name} is defeated... Game Over.");
                break;
            }

            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
        }
    }
}

