using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Think of a number between 1 and 100, and I will try to guess it.");
        Console.WriteLine("Press Enter when you're ready.");
        Console.ReadLine();

        int lowerBound = 1;
        int upperBound = 100;
        bool found = false;

        while (!found)
        {
            int guess = (lowerBound + upperBound) / 2;
            Console.WriteLine($"Is your number {guess}? (yes/no)");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes")
            {
                Console.WriteLine("Great! I guessed your number.");
                found = true;
            }
            else if (userResponse == "no")
            {
                Console.WriteLine($"Is your number higher or lower than {guess}? (higher/lower)");
                userResponse = Console.ReadLine().ToLower();

                if (userResponse == "higher")
                {
                    lowerBound = guess + 1;
                }
                else if (userResponse == "lower")
                {
                    upperBound = guess - 1;
                }
                else
                {
                    Console.WriteLine("Please enter 'higher' or 'lower'.");
                }
            }
            else
            {
                Console.WriteLine("Please enter 'yes' or 'no'.");
            }
        }

        Console.WriteLine("Thank you for playing!");
    }
}