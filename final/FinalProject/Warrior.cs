using System;
using System.Collections.Generic;

public class Warrior : Character
{
    private List<string> _abilities = new List<string> { "Power Strike", "Shield Block" };
    public Warrior()
    {
        SetHP(150);
        SetAttack(80);
        SetDefense(100);
        SetMagic(20);
    }

    public override string GetName()
    {
        return "Warrior";
    }
    public override string GetDescription()
    {
        return "Strong fighter with high strength, health, and defense.";
    }

    public override List<string> GetAbilities()
    {
        return _abilities;
    }
}
