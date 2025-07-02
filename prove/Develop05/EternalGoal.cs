public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        // Do nothing permanent — can be recorded repeatedly
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{Name},{Description},{Points}";
    }

    public override string Display()
    {
        return $"[ ] {Name} ({Description})";
    }

    public override string DisplayName()
    {
        return $"{Name}";
    }
}
