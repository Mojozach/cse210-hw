public class Elf : Character
{
    public override string Name => "Elf";
    public override string Description => "An mythic race that have high attack and intellect.";

    public override List<string> Abilities => new List<string> { "Rapid Shot", "Eagle Eye" };

    public Elf()
    {
        HP = 100;
        Attack = 85;
        Defense = 50;
        Magic = 40;
    }
}
