using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        do
        {
           Random randomGenerator = new Random();
           int randomNum = randomGenerator.Next(1, 100);
           int guesses = 0;
           int guess;
           do
           {
             Console.Write("What is your guess? ");
             string answer = Console.ReadLine().Trim();
             guess = int.Parse(answer); 
             guesses++;
             if (guess < randomNum)
                Console.WriteLine("Higher");
             else if (guess > randomNum)
                Console.WriteLine("Lower ");
   
           } while (guess != randomNum);
           Console.WriteLine("You guessed it! ");
           Console.WriteLine($"You took {guesses} guesses. ");
           Console.Write("Would you like to play again? ");
           playAgain = Console.ReadLine().Trim();
        } while (playAgain == "yes");

    }
}