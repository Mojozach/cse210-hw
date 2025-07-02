public class ChecklistGoal : Goal
{
    public int BonusPoints { get; set; }
    public int RequiredCount { get; set; }
    public int CurrentCount { get; set; }

    public override void RecordEvent()
    {
        if (CurrentCount < RequiredCount)
            CurrentCount++;
    }

    public override bool IsComplete() => CurrentCount >= RequiredCount;

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{Name},{Description},{Points},{BonusPoints},{RequiredCount},{CurrentCount}";
    }

    public override string Display()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {Name} ({Description}) -- Currently Completed: {CurrentCount}/{RequiredCount}";
    }
        public override string DisplayName()
    {
        return $"{Name}";
    }
}
