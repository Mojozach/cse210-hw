using System;
using System.Collections.Generic;

public class Wizard : Character
{
    private List<string> _abilities = new List<string> { "Fireball", "Mana Shield" };

    public Wizard()
    {
        SetHP(90);
        SetAttack(40);
        SetDefense(30);
        SetMagic(120);
    }

    public override string GetName()
    {
        return "Wizard";
    }

    public override string GetDescription()
    {
        return "Master of elemental magic with powerful spells. Has High intellect";
    }

    public override List<string> GetAbilities()
    {
        return _abilities;
    }
}
