using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

class Goals
{
    private string _fileName;
    SimpleGoals mySimpleGoals = new SimpleGoals();
    EternalGoals myEternalGoals = new EternalGoals();
    Checklist myChecklist = new Checklist();

    private int _totalPoints = 0;

    public Goals()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goals ");
        Console.WriteLine("2. Eternal Goals ");
        Console.WriteLine("3. Checklist Goal ");
        Console.Write("Which type of goal would you like to create? ");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                mySimpleGoals.Create();
                break;
            case "2":
                myEternalGoals.Create();
                break;
            case "3":
                myChecklist.Create();
                break;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }

    public void ListGoals()
    {
        int numList = 1;

        foreach (string entry in mySimpleGoals.GetSimpleGoals())
        {
            string[] items = entry.Split(',');
            if (bool.Parse(items[4]))
              Console.WriteLine($"{numList}. [X] {items[1]} ({items[2]})");
            else
              Console.WriteLine($"{numList}. [ ] {items[1]} ({items[2]})");
            numList++;
        }
        
        foreach (string entry in myEternalGoals.GetEternalGoals())
        {
            string[] items = entry.Split(',');
            Console.WriteLine($"{numList}. [ ] {items[1]} ({items[2]})");
            numList++;
        }
        
        foreach (string entry in myChecklist.GetChecklistGoals())
        {
            string[] items = entry.Split(',');
            if (int.Parse(items[5]) == int.Parse(items[6]))
                Console.WriteLine($"{numList}. [X] {items[1]} ({items[2]}) -- Currently Completed: {items[6]}/{items[5]}");
            else
                Console.WriteLine($"{numList}. [ ] {items[1]} ({items[2]}) -- Currently Completed: {items[6]}/{items[5]}");
            numList++;
        }
        Console.WriteLine();

    }

    public void SaveGoals()
    {
        Console.Write("What would you like to name the file?");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"total,{_totalPoints}");
            foreach (string entry in mySimpleGoals.GetSimpleGoals())
            {
                outputFile.WriteLine(entry);
            }
            foreach (string entry in myEternalGoals.GetEternalGoals())
            {
                outputFile.WriteLine(entry);
            }
            foreach (string entry in myChecklist.GetChecklistGoals())
            {
                outputFile.WriteLine(entry);
            }
        }

        Console.WriteLine("You have saved your Goals! ");
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file you would like to load? ");
        _fileName = Console.ReadLine();

        if (File.Exists(_fileName))
        {
            string[] lines = File.ReadAllLines(_fileName);

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                if (items[0] == "total")
                {
                    int num = int.Parse(items[1]);
                    _totalPoints = num;
                    Console.WriteLine($"{items[1]}, {num}");
                }
                else if (items[0] == "SimpleGoal")
                    mySimpleGoals.SetSimpleGoals(line);
                else if (items[0] == "EternalGoal")
                    myEternalGoals.SetEternalGoals(line);
                else
                    myChecklist.SetChecklistGoals(line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public int RecordEvent()
    {
        int numList = 1;

        foreach (string entry in mySimpleGoals.GetSimpleGoals())
        {
            string[] items = entry.Split(',');
            Console.WriteLine($"{numList}. {items[1]}");
            numList++;
        }

        foreach (string entry in myEternalGoals.GetEternalGoals())
        {
            string[] items = entry.Split(',');
            Console.WriteLine($"{numList}. {items[1]}");
            numList++;
        }

        foreach (string entry in myChecklist.GetChecklistGoals())
        {
            string[] items = entry.Split(',');
            Console.WriteLine($"{numList}. {items[1]}");
            numList++;
        }
        Console.WriteLine();

        // get the number of event
        Console.Write("Which goal did you accomplish? ");
        int listNumber = int.Parse(Console.ReadLine());

        numList = 1;
        bool found = false;

        foreach (string entry in mySimpleGoals.GetSimpleGoals())
        {
            string[] items = entry.Split(',');
            if (listNumber == numList)
            {
                _totalPoints += int.Parse(items[3]);
                Console.WriteLine($"Congratulations! You have earned {items[3]}");
                found = true;
            }
            numList++;
        }
        if (found)
            mySimpleGoals.SetActivity(listNumber-1);

        foreach (string entry in myEternalGoals.GetEternalGoals())
        {
            string[] items = entry.Split(',');
            if (listNumber == numList)
            {
                _totalPoints += int.Parse(items[3]);
                Console.WriteLine($"Congratulations! You have earned {items[3]}");
            }
            numList++;
        }

        int whichActivity = 0;
        found = false;

        foreach (string entry in myChecklist.GetChecklistGoals())
        {
            string[] items = entry.Split(',');
            if (listNumber == numList)
            {
                _totalPoints += int.Parse(items[3]);
                Console.WriteLine($"Congratulations! You have earned {items[3]}");
                found = true;
                break;
            }
            numList++;
            whichActivity++;
        }
        if (found)
        {
            int bonus = myChecklist.SetActivity(whichActivity);
            _totalPoints += bonus;
        }
        Console.WriteLine();

        Console.WriteLine($"You now have {_totalPoints}! ");

        return _totalPoints;
    }
}