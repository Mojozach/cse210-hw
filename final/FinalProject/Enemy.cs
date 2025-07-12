public class Enemy
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Enemy(string name, int hp, int attack, int defense)
    {
        Name = name;
        HP = hp;
        Attack = attack;
        Defense = defense;
    }
}