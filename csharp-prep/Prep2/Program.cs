using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine().Trim();

        if (int.TryParse(answer, out int percent))
        {
            if (percent < 0 || percent > 100)
            {
                Console.WriteLine("Please enter a percentage between 0 and 100.");
                return;
            }

            string letter = "";
            string sign = "";

            // Determine letter grade
            if (percent >= 90)
            {
                letter = "A";
            }
            else if (percent >= 80)
            {
                letter = "B";
            }
            else if (percent >= 70)
            {
                letter = "C";
            }
            else if (percent >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Determine the sign if not F
            if (letter != "F")
            {
                int lastDigit = percent % 10;

                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }

                // Remove + from A+ (not allowed)
                if (letter == "A" && sign == "+")
                {
                    sign = "";
                }
            }
            

            Console.WriteLine($"Your grade is: {letter}{sign}");

            if (percent >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
