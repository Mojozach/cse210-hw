using System;
using System.Collections.Generic;
using System.Diagnostics;

class Reflection : Activity
{
    List<string> _prompt = new List<string>
    {
       "Think of a time when you stood up for someone else. ",
       "Think of a time when you did something really difficult. ",
       "Think of a time when you helped someone in need. ",
       "When have you felt the Holy Ghost this month? ",
       "Think of a time when you did something truly selfless. "
    };
     List<string> _prompt2 = new List<string>
    {
       "Think of a time when you stood up for someone else. ",
       "Think of a time when you did something really difficult. ",
       "Think of a time when you helped someone in need. ",
       "When have you felt the Holy Ghost this month? ",
       "Think of a time when you did something truly selfless. "
    };
    public Reflection()
    {
    
    }
    public void PerformActivity()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("\nThis Activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("\n How long, in seconds, would you like for your session? ");
        DisplayStartMessage();

        Console.WriteLine("Consider the following prompt: ");

        // Write a random prompt
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        string randomPrompt = _prompt[index];
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine($"When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        Countdown(5);
        int timer = 0;
        Console.Clear();
        while (timer < _time)
        {
            Random random2 = new Random();
            index = random2.Next(_prompt2.Count);
            string randomPrompt2 = _prompt2[index];
            Console.Write($"{randomPrompt2} ");
            ShowSpinner(10);
            timer += 10;
        }

        DisplayEndMessage("reflection");
    }
}