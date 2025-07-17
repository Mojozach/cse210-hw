using System;
using System.Collections.Generic;

public class Enemy : Character
{
    private string name;
    private List<string> abilities = new List<string> { "Bite", "Roar" };

    public Enemy(string name, int hp, int attack, int defense, int magic = 0)
    {
        this.name = name;
        SetHP(hp);
        SetAttack(attack);
        SetDefense(defense);
        SetMagic(magic);
    }

    public override string GetName() => name;

    public override string GetDescription() => "The squeaking of the floor indicates the enemy arrival";

    public override List<string> GetAbilities() => abilities;
}
