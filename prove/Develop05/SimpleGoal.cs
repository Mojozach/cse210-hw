using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

class SimpleGoals
{
    private string _goal;
    private string _description;
    private int _points;
    private List<string> _simpleGoals = new List<string> { };

    public SimpleGoals()
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
        string newList = $"SimpleGoal,{_goal},{_description},{_points},False";
        _simpleGoals.Add(newList);
    }

    public List<string> GetSimpleGoals()
    {
        return _simpleGoals;
    }

    public void SetSimpleGoals(string simpleGoals)
    {
        //_simpleGoals.Clear();
        _simpleGoals.Add(simpleGoals);
    }

    public void SetActivity(int listNumber)
    {
        string[] entries = _simpleGoals[listNumber].Split(','); 
        entries[4] = "True";
        _simpleGoals[listNumber] = string.Join(",", entries); 
    }

}