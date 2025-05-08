using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain) // Loop to allow replaying the game
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Generate random number between 1 and 100
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to Guess My Number! Try to guess the magic number.");

            while (guess != magicNumber) // Loop until the correct number is guessed
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

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
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing! See you next time.");
    }
}
