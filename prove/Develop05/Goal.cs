public class Goals
{
    private List<Goal> _allGoals = new List<Goal>();
    private int _totalPoints;

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = CreateSimple();
                break;
            case "2":
                newGoal = CreateEternal();
                break;
            case "3":
                newGoal = CreateChecklist();
                break;
        }

        if (newGoal != null) _allGoals.Add(newGoal);
    }

    private SimpleGoal CreateSimple()
    {
        var g = new SimpleGoal();
        FillCommonFields(g);
        g.Completed = false;
        return g;
    }

    private EternalGoal CreateEternal()
    {
        var g = new EternalGoal();
        FillCommonFields(g);
        return g;
    }

    private ChecklistGoal CreateChecklist()
    {
        var g = new ChecklistGoal();
        FillCommonFields(g);
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        g.RequiredCount = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        g.BonusPoints = int.Parse(Console.ReadLine());
        g.CurrentCount = 0;
        return g;
    }

    private void FillCommonFields(Goal g)
    {
        Console.Write("What is the name of your goal? ");
        g.Name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        g.Description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        g.Points = int.Parse(Console.ReadLine());
    }

    public void JustGoals()
    {
        int i = 1;
        foreach (var g in _allGoals)
        {
            Console.WriteLine($"{i}. {g.DisplayName()}");
            i++;
        }
    }
    public void ListGoals()
    {
        int i = 1;
        foreach (var g in _allGoals)
        {
            Console.WriteLine($"{i}. {g.Display()}");
            i++;
        }
    }

    public int RecordEvent()
    {
        JustGoals();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= _allGoals.Count)
        {
            var goal = _allGoals[choice - 1];
            goal.RecordEvent();
            _totalPoints += goal.Points;

            if (goal is ChecklistGoal cg && cg.IsComplete())
            {
                _totalPoints += cg.BonusPoints;
            }

            Console.WriteLine($"Congratulations! You've earned {goal.Points} points!");
        }
        return (_totalPoints);
    }

    public void SaveGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        using (var writer = new StreamWriter(file))
        {
            writer.WriteLine($"total,{_totalPoints}");
            foreach (var goal in _allGoals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            _allGoals.Clear();

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts[0] == "total")
                {
                    _totalPoints = int.Parse(parts[1]);
                }
                else if (parts[0] == "SimpleGoal")
                {
                    _allGoals.Add(new SimpleGoal
                    {
                        Name = parts[1],
                        Description = parts[2],
                        Points = int.Parse(parts[3]),
                        Completed = bool.Parse(parts[4])
                    });
                }
                else if (parts[0] == "EternalGoal")
                {
                    _allGoals.Add(new EternalGoal
                    {
                        Name = parts[1],
                        Description = parts[2],
                        Points = int.Parse(parts[3])
                    });
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    _allGoals.Add(new ChecklistGoal
                    {
                        Name = parts[1],
                        Description = parts[2],
                        Points = int.Parse(parts[3]),
                        BonusPoints = int.Parse(parts[4]),
                        RequiredCount = int.Parse(parts[5]),
                        CurrentCount = int.Parse(parts[6])
                    });
                }
            }
        }
    }

    public int GetPoints()
    {
        return (_totalPoints);
    }
}
