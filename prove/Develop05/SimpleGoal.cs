using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public bool GetCompleted()
    {
        return _completed;
    }

    public void SetCompleted(bool value)
    {
        _completed = value;
    }

    public override void RecordEvent()
    {
        SetCompleted(true);
    }

    public override bool IsComplete() => GetCompleted();

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{GetCompleted()}";
    }

    public override string Display()
    {
        string check = GetCompleted() ? "[X]" : "[ ]";
        return $"{check} {GetName()} ({GetDescription()})";
    }

    public override string DisplayName()
    {
        return $"{GetName()}";
    }
}