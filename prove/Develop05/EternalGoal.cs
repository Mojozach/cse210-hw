using System;
class EternalGoals
{
    private string _description;
    private string _goal;
    private int _points;
    private List<string> _eternalGoals = new List<string> { };

    public EternalGoals()
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
        string newList = $"EternalGoal,{_goal},{_description},{_points}";
        _eternalGoals.Add(newList);
    }  
    public List<string> GetEternalGoals()
    {
        return _eternalGoals;
    }

    public void SetEternalGoals(string eternalGoals)
    {
        //_simpleGoals.Clear();
        _eternalGoals.Add(eternalGoals);
    }
  
}