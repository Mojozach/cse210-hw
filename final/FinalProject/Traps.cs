using System;

public class Trap
{
    private string _name;
    private int _damage;
    private bool _isActive;

    public Trap(string name, int damage)
    {
        _name = name;
        _damage = damage;
        _isActive = true;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetDamage()
    {
        return _damage;
    }
    public bool IsActive()
    {
        return _isActive;
    }
    public void Trigger()
    {
        if (_isActive)
        {
            Console.WriteLine($"Trap '{_name}' is triggered! It deals {_damage} damage.");
            _isActive = false;
        }
        else
        {
            Console.WriteLine($"Trap '{_name}' has already been triggered.");
        }
    }

    public void Reset()
    {
        _isActive = true;
        Console.WriteLine($"Trap '{_name}' has been reset.");
    }
}
