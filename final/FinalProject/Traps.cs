using System;

public abstract class Trap
{
    public string Name { get; }
    public string Description { get; }

    public Trap(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Trigger();
}

public class NormalTrap : Trap
{
    public NormalTrap(string name, string description)
        : base(name, description) { }

    public override void Trigger()
    {
        Console.WriteLine($"\nTrap Triggered: {Name}");
        Console.WriteLine($"{Description}");
    }
}

public class TimedTrap : Trap
{
    public int DelaySeconds { get; }

    public TimedTrap(string name, string description, int delaySeconds)
        : base(name, description)
    {
        DelaySeconds = delaySeconds;
    }

    public override void Trigger()
    {
        Console.WriteLine($"\nTimed Trap Detected: {Name} (activates in {DelaySeconds} seconds)");
        for (int i = DelaySeconds; i > 0; i--)
        {
            Console.WriteLine($"...{i}");
            System.Threading.Thread.Sleep(1000); // Simulates countdown 
        }
        Console.WriteLine($"{Name} has activated! {Description}");
    }
}
