using System;
using System.Threading;

public class Activity
{
    public int _time;
    public Activity()
    {
    }

    public void ShowSpinner(int durationInSeconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int totalFrames = durationInSeconds * 5; // 5 frames per second
        for (int i = 0; i < totalFrames; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.Write(" ");
        Console.WriteLine();
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.Write(" ");
        Console.WriteLine();
    }

    public void DisplayStartMessage()
    {
        while (!int.TryParse(Console.ReadLine(), out _time) || _time <= 0)
            if (!int.TryParse(Console.ReadLine(), out _time))
            {
                Console.WriteLine("Please enter a valid number greater than 0: ");
            }
        Console.Clear();
        Console.WriteLine("Get ready... ");

        ShowSpinner(3);
    }

    protected void DisplayEndMessage(string activityName)
    {
        Console.WriteLine("Well done!!!");
        ShowSpinner(3);
        Console.WriteLine($"Great job! You've completed the {activityName} activity for {_time} seconds.");
        ShowSpinner(3);
        Console.Clear();
    }
}
