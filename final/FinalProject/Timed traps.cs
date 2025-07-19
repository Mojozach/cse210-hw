using System;

// This is my timed trap class.  Still a work in progress.
public class TimedTrap
{
    private string _name;
    private int _damage;
    private int _timer;
    private bool _isTriggered;

    public TimedTrap(string name, int damage, int timer)
    {
        _name = name;
        _damage = damage;
        _timer = timer;
        _isTriggered = false;
    }

    public string GetName()
    {
        return (_name);
    }

    public int GetDamage()
    {
        return _damage;
    }
    public int GetTimer()
    {
        return _timer;
    }
    public bool HasTriggered()
    {
        return _isTriggered;
    }

    public void Tick()
    {
        if (!_isTriggered)
        {
            _timer--;

            if (_timer <= 0)
            {
                Trigger();
            }
            else
            {
                Console.WriteLine($"Trap '{_name}' will trigger in {_timer} ticks.");
            }
        }
    }

    private void Trigger()
    {
        Console.WriteLine($"Timed trap '{_name}' has triggered! It deals {_damage} damage.");
        _isTriggered = true;
    }

    public void Reset(int newTimer)
    {
        _timer = newTimer;
        _isTriggered = false;
        Console.WriteLine($"Timed trap '{_name}' has been reset. It will trigger in {_timer} ticks.");
    }
}
