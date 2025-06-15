using System;
using System.Threading;

class Breathing : Activity
{
    public Breathing()
    {

    }
    public void PerformActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("\nThis Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("\n How long, in seconds, would you like for your session? ");

        DisplayStartMessage();

        int elapsed = 0;
        int breathCycleTime = 6;

        while (elapsed + breathCycleTime <= _time)
        {
            Console.Write("Breath in...");
            Countdown(3);
            Console.Write("Breath out...");
            Countdown(3);
            Console.WriteLine();
            elapsed += breathCycleTime;
        }
        DisplayEndMessage("breathing");
    }
}