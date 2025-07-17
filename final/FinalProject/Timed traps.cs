using System;

public class TimedTrap
{
    private string name;
    private int damage;
    private int timer;
    private bool isTriggered;

    public TimedTrap(string name, int damage, int timer)
    {
        this.name = name;
        this.damage = damage;
        this.timer = timer;
        this.isTriggered = false;
    }

    public string GetName()
    {
        return (name);
    }
    
    public int GetDamage() => damage;
    public int GetTimer() => timer;
    public bool HasTriggered() => isTriggered;

    public void Tick()
    {
        if (!isTriggered)
        {
            timer--;

            if (timer <= 0)
            {
                Trigger();
            }
            else
            {
                Console.WriteLine($"Trap '{name}' will trigger in {timer} ticks.");
            }
        }
    }

    private void Trigger()
    {
        Console.WriteLine($"Timed trap '{name}' has triggered! It deals {damage} damage.");
        isTriggered = true;
    }

    public void Reset(int newTimer)
    {
        timer = newTimer;
        isTriggered = false;
        Console.WriteLine($"Timed trap '{name}' has been reset. It will trigger in {timer} ticks.");
    }
}
