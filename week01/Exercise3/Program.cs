using System;

class Program
{
    static void Main(string[] args)
    {
     // Step 3: Generate a random number from 1 to 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // 1 to 100 inclusive

        int guess = 0;

        Console.WriteLine("Welcome to 'Guess My Number'!");
        Console.WriteLine("I'm thinking of a number between 1 and 100...");

        // Step 2: Loop until the user guesses the correct number
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();

            // Validate input
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            // Step 1: Give feedback
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}