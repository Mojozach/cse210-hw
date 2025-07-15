public class Enemy : Character
{
    public override string Name { get; }
    public override string Description => "The squeaking of the floor indicates the enemy arrival";
    public override List<string> Abilities { get; }

    public Enemy(string name, int hp, int attack, int defense, int magic = 0)
    {
        Name = name;
        HP = hp;
        Attack = attack;
        Defense = defense;
        Magic = magic;
        Abilities = new List<string> { "Bite", "Roar" };
    }
}