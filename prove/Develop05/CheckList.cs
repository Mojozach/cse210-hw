using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _requiredCount;
    private int _currentCount;

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetBonusPoints(int value)
    {
        _bonusPoints = value;
    }

    public int GetRequiredCount()
    {
        return _requiredCount;
    }

    public void SetRequiredCount(int value)
    {
        _requiredCount = value;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public void SetCurrentCount(int value)
    {
        _currentCount = value;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _requiredCount)
        {
            _currentCount++;
        }
    }

    public override bool IsComplete() => _currentCount >= _requiredCount;

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_bonusPoints},{_requiredCount},{_currentCount}";
    }

    public override string Display()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {GetName()} ({GetDescription()}) -- Currently Completed: {_currentCount}/{_requiredCount}";
    }

    public override string DisplayName()
    {
        return $"{GetName()}";
    }
}