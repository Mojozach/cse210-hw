using System;
using System.Collections.Generic;

public class Combat
{
    public Combat()
    {
    }

    public static void Battle(Character player, Character enemy)
    {
        Console.WriteLine($"{enemy.GetName()}");
        Console.WriteLine($"{enemy.GetDescription()}");
        Console.WriteLine("=== Stats ===");
        Console.WriteLine($"HP:      {enemy.GetHP()}");
        Console.WriteLine($"Attack:  {enemy.GetAttack()}");
        Console.WriteLine($"Defense: {enemy.GetDefense()}");
        Console.WriteLine($"Magic:   {enemy.GetMagic()}");
        Console.WriteLine("Abilities: " + string.Join(", ", enemy.GetAbilities()));

        Console.WriteLine($"\nBattle Start: {player.GetName()} VS {enemy.GetName()}!");

        while (player.GetHP() > 0 && enemy.GetHP() > 0)
        {
            ExecuteTurn(player, enemy);
            if (enemy.GetHP() <= 0) break;

            ExecuteTurn(enemy, player);
        }

        Console.WriteLine(player.GetHP() > 0
            ? $"\n{player.GetName()} is victorious!"
            : $"\n{player.GetName()} has fallen...");
    }

    private static void ExecuteTurn(Character attacker, Character defender)
    {
        int damage = Math.Max(attacker.GetAttack() - defender.GetDefense(), 0);
        defender.TakeDamage(damage);
        Console.WriteLine($"{attacker.GetName()} attacks for {damage} damage! {defender.GetName()} HP: {defender.GetHP()}");
    }
}
