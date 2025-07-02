public class SimpleGoal : Goal
{
    public bool Completed { get; set; }

    public override void RecordEvent()
    {
        Completed = true;
    }

    public override bool IsComplete() => Completed;

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{Name},{Description},{Points},{Completed}";
    }

    public override string Display()
    {
        string check = Completed ? "[X]" : "[ ]";
        return $"{check} {Name} ({Description})";
    }
    
    public override string DisplayName()
    {
        return $"{Name}";
    }
}
