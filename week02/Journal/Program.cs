using System;
using System.Collections.Generic;

class Program
{
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn today?"
    };

    static Journal journal = new Journal();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nJournal App Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a JSON file");
            Console.WriteLine("4. Load the journal from a JSON file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename to save (e.g., journal.json): ");
                    journal.SaveJournalAsJson(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename to load (e.g., journal.json): ");
                    journal.LoadJournalFromJson(Console.ReadLine());
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine("\n" + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Console.Write("Rate your mood today (1-10): ");
        int moodRating;
        while (!int.TryParse(Console.ReadLine(), out moodRating) || moodRating < 1 || moodRating > 10)
        {
            Console.Write("Invalid input. Enter a number between 1 and 10: ");
        }

        journal.AddEntry(prompt, response, moodRating);
    }
}
