using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public string GetName()
    {
        return _name;
    }
    public void SetName(string value)
    {
        _name = value;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string value)
    {
        _description = value;
    }

    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int value)
    {
        _points = value;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public abstract string Display();
    public abstract string DisplayName();
}
