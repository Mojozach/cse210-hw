public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public abstract string GetStringRepresentation();
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string Display();
    public abstract string DisplayName();
}
