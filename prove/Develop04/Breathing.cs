using System;
using System.Threading;

class Breathing
{
    private int _time;
    public Breathing()
    {

    }
    public void PerformActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("\nThis Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("\n How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
        //Console.Clear();
        //Console.WriteLine("Get ready... ");
        //animation
        //string[] spinner = { "/", "-", "\\", "|" };
        while (!int.TryParse(Console.ReadLine(), out _time) || _time <= 0)
            if (!int.TryParse(Console.ReadLine(), out _time))
            {
                Console.WriteLine("Please enter a valid number greater than 0: ");
            }
        Console.Clear();
        Console.WriteLine("Get ready... ");

        ShowSpinner(3);

        int elapsed = 0;
        int breathCycleTime = 6;

        while (elapsed + breathCycleTime <= _time)
        {
            Console.Write("Breath in...");
            Countdown(3);
            Console.Write("Breath out..");
            Countdown(3);
            Console.WriteLine();
            elapsed += breathCycleTime;
        }

        Console.WriteLine("\nGreat job! You've completed the breathing activity.");
    }

private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    private void ShowSpinner(int durationInSeconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int totalFrames = durationInSeconds * 5; // 5 frames per second
        for (int i = 0; i < totalFrames; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine();
    }
}