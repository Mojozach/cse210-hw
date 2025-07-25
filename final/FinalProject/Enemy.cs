using System;
using System.Collections.Generic;

public class Enemy : Character
{
    private string _name;
    private List<string> _abilities = new List<string> { "Bite", "Roar" };

    public Enemy(string name, int hp, int attack, int defense, int magic = 0)
    {
        _name = name;
        SetHP(hp);
        SetAttack(attack);
        SetDefense(defense);
        SetMagic(magic);
    }

    public override string GetName()
    {
        return _name;
    }

    public override string GetDescription()
    {
        return "The squeaking of the floor indicates the enemy arrival";
    }

    public override List<string> GetAbilities()
    {
        return _abilities;
    }
}
