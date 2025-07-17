using System;
using System.Collections.Generic;

public class Wizard : Character
{
    private List<string> abilities = new List<string> { "Fireball", "Mana Shield" };

    public Wizard()
    {
        SetHP(90);
        SetAttack(40);
        SetDefense(30);
        SetMagic(120);
    }

    public override string GetName() => "Wizard";

    public override string GetDescription() => "Master of elemental magic with powerful spells. Has High intellect";

    public override List<string> GetAbilities() => abilities;
}
