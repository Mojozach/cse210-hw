using System;

public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        // Eternal goals never complete, but they can be logged repeatedly
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{GetName()},{GetDescription()},{GetPoints()}";
    }

    public override string Display()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override string DisplayName()
    {
        return $"{GetName()}";
    }

    public override bool IsComplete()
    {
        return false;
    }
}