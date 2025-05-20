//Enhancements
//1. Reads from a JSON file and presents a random scripture each session.
//2. Words get hidden strategically to increase memorization difficulty
//3. Users can request hint to reveal the first letter of each hidden word
//4. Every session starts with a different scripture, preventing repetition.




using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();
        
        // Load a random scripture from file
        Scripture scripture = LoadRandomScripture();

        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress ENTER to hide words, type 'hint' for help, or type 'quit' to exit.");

            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit") break;
            if (input == "hint")
            {
                Console.Clear();
                Console.WriteLine("\nHint Mode Activated:");
                Console.WriteLine(scripture.GetScriptureWithHints());
                Console.WriteLine("\nPress ENTER to continue.");
                Console.ReadLine();
                continue;
            }

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nScripture is fully hidden. Goodbye!");
    }

    static Scripture LoadRandomScripture()
    {
        string jsonPath = "scriptures.json";
        string jsonData = File.ReadAllText(jsonPath);
        var scriptureList = JsonSerializer.Deserialize<Dictionary<string, List<Dictionary<string, string>>>>(jsonData);

        var scriptures = scriptureList["scriptures"];
        var random = new Random();
        var selectedScripture = scriptures[random.Next(scriptures.Count)];

        string referenceText = selectedScripture["reference"];
        string verseText = selectedScripture["text"];

        var parts = referenceText.Split(" ");
        var chapterVerse = parts[1].Split(":");
        Reference reference;

        if (chapterVerse.Length == 1)
            reference = new Reference(parts[0], int.Parse(chapterVerse[0]), 1);
        else
            reference = new Reference(parts[0], int.Parse(chapterVerse[0]), int.Parse(chapterVerse[1]));

        return new Scripture(reference, verseText);
    }
}
