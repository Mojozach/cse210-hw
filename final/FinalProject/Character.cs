using System;
using System.Collections.Generic;

public abstract class Character
{
    private int _hp;
    private int _attack;
    private int _defense;
    private int _magic;

    public int GetHP()
    {
        return _hp;
    }
    public void SetHP(int value)
    {
        _hp = value;
    }

    public int GetAttack()
    {
        return _attack;
    }
    public void SetAttack(int value)
    {
        _attack = value;
    }
    public int GetDefense()
    {
        return _defense;
    }
    public void SetDefense(int value)
    {
        _defense = value;
    }

    public int GetMagic()
    {
        return _magic;
    }
    public void SetMagic(int value)
    {
        _magic = value;
    }

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
