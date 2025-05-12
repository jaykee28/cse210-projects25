/*
    Journal App - Exceeding Requirements
    Enhancements:
    1. **Mood Tracking**: Users rate their mood from 1 to 10 with each journal entry.
    2. **JSON Storage**: Saves and loads journal entries in structured JSON format for better readability and future web integration.
    3. **Input Validation**: Ensures mood rating is between 1-10, preventing unexpected errors.
    4. **Improved User Experience**:
       - Displays prompts dynamically.
       - Handles file errors gracefully.
*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(string prompt, string response, int moodRating)
    {
        Entries.Add(new Entry(prompt, response, moodRating));
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveJournalAsJson(string filename)
    {
        string json = JsonSerializer.Serialize(Entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine("Journal saved successfully as JSON.");
    }

    public void LoadJournalFromJson(string filename)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            Entries = JsonSerializer.Deserialize<List<Entry>>(json);
            Console.WriteLine("Journal loaded successfully from JSON.");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
