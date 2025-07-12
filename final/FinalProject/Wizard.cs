public class Wizard : Character
{
    public override string Name => "Wizard";
    public override string Description => "Master of elemental magic with powerful spells. Has High intellect";
    public override List<string> Abilities => new List<string> { "Fireball", "Mana Shield" };

    public Wizard()
    {
        HP = 90;
        Attack = 40;
        Defense = 30;
        Magic = 120;
    }
}