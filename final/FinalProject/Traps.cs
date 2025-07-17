using System;

public class Trap
{
    private string name;
    private int damage;
    private bool isActive;

    public Trap(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
        this.isActive = true;
    }

    public string GetName() => name;
    public int GetDamage() => damage;
    public bool IsActive() => isActive;

    public void Trigger()
    {
        if (isActive)
        {
            Console.WriteLine($"Trap '{name}' is triggered! It deals {damage} damage.");
            isActive = false;
        }
        else
        {
            Console.WriteLine($"Trap '{name}' has already been triggered.");
        }
    }

    public void Reset()
    {
        isActive = true;
        Console.WriteLine($"Trap '{name}' has been reset.");
    }
}
