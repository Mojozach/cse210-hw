using System;
using System.Collections.Generic;

public class Elf : Character
{
    private List<string> _abilities = new List<string> { "Rapid Shot", "Eagle Eye" };

    public Elf()
    {
        SetHP(100);
        SetAttack(85);
        SetDefense(50);
        SetMagic(40);
    }

    public override string GetName()
    {
        return "Elf";
    }

    public override string GetDescription()
    {
        return "An mythic race that have high attack and intellect.";
    }

    public override List<string> GetAbilities()
    {
        return _abilities;
    }
}
