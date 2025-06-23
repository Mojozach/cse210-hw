using System;
using System.Collections.Generic;
using System.Diagnostics;
//Made it so for prompt2 it doesn't repeat questions till all questions been answered.
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
       "Why was this experience meaningful to you? ",
       "Have you ever done anything like this before? ",
       "How did you get started? ",
       "How did you feel when it was complete? ",
       "What made this time different than other times when you were not as successful? ",
       "What is your favorite thing about this experience? ",
       "What could you learn from this experience that applies to other situations? ",
       "What did you learn about yourself through this experience?",
       "How can you keep this experience in mind in the future? "
    };
    
    // List of available remaining questions
    List<string> availQuestions;
    public Reflection()
    {
        availQuestions = new List<string>(_prompt2);
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
            // After pool is empty, reset:
            if (availQuestions.Count == 0)
            {
                availQuestions = new List<string>(_prompt2);
            }

            Random random2 = new Random();
            index = random2.Next(availQuestions.Count);
            string randomPrompt2 = availQuestions[index];
            availQuestions.RemoveAt(index); // Remove to avoid repetition
            Console.Write($"{randomPrompt2} ");
            ShowSpinner(10);
            timer += 10;
        }

        DisplayEndMessage("reflection");
        Console.Clear();
    }

}