using System.Collections.Generic;

public class Combat
{

    public Combat()
    {

    }

    public static void Battle(Character player, Character enemy)
    {
        Console.WriteLine($"{enemy.Name}");
        Console.WriteLine($"{enemy.Description}");
        Console.WriteLine("=== Stats ===");
        Console.WriteLine($"HP:      {enemy.HP}");
        Console.WriteLine($"Attack:  {enemy.Attack}");
        Console.WriteLine($"Defense: {enemy.Defense}");
        Console.WriteLine($"Magic:   {enemy.Magic}");
        Console.WriteLine("Abilities: " + string.Join(", ", enemy.Abilities));

        Console.WriteLine($"\nBattle Start: {player.Name} VS {enemy.Name}!");
    
        while (player.HP > 0 && enemy.HP > 0)
        {
            ExecuteTurn(player, enemy);
            if (enemy.HP <= 0) break;
    
            ExecuteTurn(enemy, player);
        }
    
        Console.WriteLine(player.HP > 0 ? $"\n{player.Name} is victorious!" : $"\n{player.Name} has fallen...");
    }

    private static void ExecuteTurn(Character attacker, Character defender)
    {
        int damage = Math.Max(attacker.Attack - defender.Defense, 0);
        defender.TakeDamage(damage);
        Console.WriteLine($"{attacker.Name} attacks for {damage} damage! {defender.Name} HP: {defender.HP}");
    }
}


 