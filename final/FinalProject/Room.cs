using System;
using System.Collections.Generic;

public class Room
{
    private string _name;
    private string _description;
    private Enemy _encounter;

    public Room(string name, string description, Enemy encounter = null)
    {
        _name = name;
        _description = description;
        _encounter = encounter;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public Enemy GetEncounter()
    {
        return _encounter;
    }

    public static Room SelectRoom()
    {
        var rooms = new List<Room>()
        {
            new Room("Training Grounds", "A place to sharpen your skills."),
            new Room("Mystic Library", "Filled with ancient knowledge."),
            new Room("Fight Arena", "The place where battles are fought."),
        };

        Console.WriteLine("\nChoose a room to enter:");

        for (int i = 0; i < rooms.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {rooms[i].GetName()} - {rooms[i].GetDescription()}");
        }

        while (true)
        {
            Console.Write("Enter room number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= rooms.Count)
            {
                return rooms[choice - 1];
            }
            Console.WriteLine("Invalid room selection. Please try again.");
        }
    }
}
