using System;
using System.Collections.Generic;

public abstract class Character
{
    private int hp;
    private int attack;
    private int defense;
    private int magic;

    public int GetHP() => hp;
    public void SetHP(int value) => hp = value;

    public int GetAttack() => attack;
    public void SetAttack(int value) => attack = value;

    public int GetDefense() => defense;
    public void SetDefense(int value) => defense = value;

    public int GetMagic() => magic;
    public void SetMagic(int value) => magic = value;

    public abstract string GetName();
    public abstract string GetDescription();
    public abstract List<string> GetAbilities();

    public void ShowStats()
    {
        Console.WriteLine($"\n{GetName()} Stats:");
        Console.WriteLine($"HP: {GetHP()}");
        Console.WriteLine($"Attack: {GetAttack()}");
        Console.WriteLine($"Defense: {GetDefense()}");
        Console.WriteLine($"Magic: {GetMagic()}");
    }
    public void TakeDamage(int amount)
    {
        SetHP(Math.Max(0, GetHP() - amount));
    }

}
