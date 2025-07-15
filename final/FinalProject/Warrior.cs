using System;
using System.Collections.Generic;

public class Warrior : Character
{
    public override string Name => "Warrior";
    public override string Description => "Strong fighter with high strength, health, and defense.";
    public override List<string> Abilities => new List<string> { "Power Strike", "Shield Block" };

    public Warrior()
    {
        HP = 150;
        Attack = 80;
        Defense = 100;
        Magic = 20;
    }
}