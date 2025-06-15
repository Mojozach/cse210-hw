using System;
using System.Collections.Generic;
using System.Diagnostics;

class Listing : Activity
{
    List<string> _prompt = new List<string>
    {
       "Who are people that you appreciate? ",
       "What are personal strengths of yours? ",
       "Who are people that you have helped this week? ",
       "When have you felt the Holy Ghost this month? ",
       "Who are some of your personal heroes? "
    };

    // Constructor for Listing Class
    public Listing()
    {
    
    }
    public void PerformActivity()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("\nThis Activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("\n How long, in seconds, would you like for your session? ");
        DisplayStartMessage();

        Console.WriteLine("List as many responses you can to the following prompt: ");

        // Write a random prompt
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        string randomPrompt = _prompt[index];
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine($"You may begin in: ");
        Countdown(5);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int responses = 0;

        while (stopwatch.Elapsed.TotalSeconds < _time)
        {
            Console.Write("> ");
            Console.ReadLine();
            responses += 1;

            Thread.Sleep(100); 
        }

        stopwatch.Stop();
        Console.WriteLine($"You listed {responses} items!");
        DisplayEndMessage("listing");
    }
}