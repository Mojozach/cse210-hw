using System;
class Checklist
{
    private string _description;
    private string _goal;
    private int _points;
    private int _bonusPoints;
    private int _maxTries;
    private int _numTries;
    private List<string> _checklistGoals = new List<string> { };

    public Checklist()
    {

    }

    public void Create()
    {
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _maxTries = int.Parse(Console.ReadLine());
        Console.Write("What is the the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        _numTries = 0;
        string newList = $"ChecklistGoal,{_goal},{_description},{_points},{_bonusPoints},{_maxTries},{_numTries}";
        _checklistGoals.Add(newList);
    }

    public List<string> GetChecklistGoals()
    {
        return _checklistGoals;
    }

    public void SetChecklistGoals(string checklistGoals)
    {
        //_simpleGoals.Clear();
        _checklistGoals.Add(checklistGoals);
    }

    public int SetActivity(int whichActivity)
    {
        string[] entries = _checklistGoals[whichActivity].Split(',');
        _bonusPoints = int.Parse(entries[4]);
        _maxTries = int.Parse(entries[5]);
        _numTries = int.Parse(entries[6]);
        if (_numTries < _maxTries)
        {
            _numTries++;
            entries[6] = _numTries.ToString();
            _checklistGoals[whichActivity] = string.Join(",", entries);
        }
        
        if (_numTries == _maxTries)
        {
            return _bonusPoints;
        }
        else
            return 0;

    }
}