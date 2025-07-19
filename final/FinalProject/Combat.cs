using System;
using System.Collections.Generic;

public class Combat
{
    public static void Battle(Character player, Character enemy)
    {
        Console.WriteLine($"{enemy.GetName()}");
        Console.WriteLine($"{enemy.GetDescription()}");
        Console.WriteLine("=== Stats ===");
        Console.WriteLine("HP:      " + enemy.GetHP());
        Console.WriteLine("Attack:  " + enemy.GetAttack());
        Console.WriteLine("Defense: " + enemy.GetDefense());
        Console.WriteLine("Magic:   " + enemy.GetMagic());
        Console.WriteLine("Abilities: " + string.Join(", ", enemy.GetAbilities()));

        Console.WriteLine("\nBattle Start: " + player.GetName() + " VS " + enemy.GetName() + "!");

        bool playerTurn = true;

        while (player.GetHP() > 0 && enemy.GetHP() > 0)
        {
            if (playerTurn)
            {
                PlayerTurn(player, enemy);
            }
            else
            {
                EnemyTurn(enemy, player);
            }
            playerTurn = !playerTurn; // Switch turns
        }

        if (player.GetHP() > 0)
        {
            Console.WriteLine("\n" + player.GetName() + " is victorious!");
        }
        else
        {
            Console.WriteLine("\n" + player.GetName() + " has fallen...");
        }
    }

    private static void PlayerTurn(Character player, Character enemy)
    {
        Console.WriteLine($"\nYour turn! Choose an attack:");

        List<string> abilities = player.GetAbilities();

        for (int i = 0; i < abilities.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {abilities[i]}");
        }
        Console.WriteLine($"{abilities.Count + 1}. Basic Attack");

        int choice = 0;

        while (true)
        {
            Console.Write("Enter the number of your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                if (choice >= 1 && choice <= abilities.Count + 1)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input, please try again.");
        }


        if (choice == abilities.Count + 1)
        {
            // Basic attack
            int damage = player.GetAttack() - enemy.GetDefense();
            if (damage < 0) damage = 0;
            enemy.TakeDamage(damage);
            Console.WriteLine($"{player.GetName()} performs a Basic Attack for {damage} damage! {enemy.GetName()} HP: {enemy.GetHP()}");
        }
        else
        {
            if (player.GetName() == "Wizard")
            {
                // Use special ability - magic attack deals magic stat * 2 minus defense
                string ability = abilities[choice - 1];
                int damage = (player.GetMagic() * 2) - enemy.GetDefense();
                if (damage < 0)
                    damage = 0;
                enemy.TakeDamage(damage);
                Console.WriteLine($"{player.GetName()} uses {ability} and deals {damage} damage! {enemy.GetName()} HP: {enemy.GetHP()}");
            }
            else
            {
                // Use special ability - warrior and elf
                string ability = abilities[choice - 1];
                int damage = (player.GetAttack() * 2) - enemy.GetDefense();
                if (damage < 0)
                    damage = 0;
                enemy.TakeDamage(damage);
                Console.WriteLine($"{player.GetName()} uses {ability} and deals {damage} damage! {enemy.GetName()} HP: {enemy.GetHP()}");
            }
        }
    }

    private static void EnemyTurn(Character enemy, Character player)
    {
        // Enemy uses a basic attack -(in the future might change this but probably won't get updated.)
        int damage = enemy.GetAttack() - player.GetDefense();
        if (damage < 0) damage = 0;
        player.TakeDamage(damage);
        Console.WriteLine($"{enemy.GetName()} attacks for {damage} damage! {player.GetName()} HP: {player.GetHP()}");
    }
}
