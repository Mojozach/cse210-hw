using System;
using System.Collections.Generic;

public class Warrior : Character
{
    public Warrior()
    {
        SetHP(150);
        SetAttack(80);
        SetDefense(100);
        SetMagic(20);
    }

    public override string GetName() => "Warrior";

    public override string GetDescription() => "Strong fighter with high strength, health, and defense.";

    public override List<string> GetAbilities() => new List<string> { "Power Strike", "Shield Block" };
}
