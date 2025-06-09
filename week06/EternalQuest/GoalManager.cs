using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private Player player;

    public GoalManager(string playerName)
    {
        player = new Player(playerName);
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.FirstOrDefault(g => g.Name == goalName);
        if (goal != null)
        {
            int points = goal.RecordProgress();
            player.AddPoints(points);
            Console.WriteLine($"✅ Progress recorded for '{goalName}'! Earned {points} points.");
            DisplayPlayerStatus();
        }
        else
        {
            Console.WriteLine("⚠️ Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
        DisplayPlayerStatus();
    }

    public void DisplayPlayerStatus()
    {
        player.DisplayStatus();
    }

    // **Save completed goals and player progress**
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(player.Score); // Save player score first

            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.GetPoints()},{goal.GetStatus()}");
            }
        }
        Console.WriteLine("📂 Goals saved successfully.");
    }

    // **Load goals from the file**
    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                if ((line = reader.ReadLine()) != null)
                {
                    player.SetScore(int.Parse(line)); // Restore player score
                }

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        string type = parts[0];
                        string name = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isCompleted = parts[3] == "[X] Completed";

                        Goal goal = type switch
                        {
                            "SimpleGoal" => new SimpleGoal(name, points),
                            "EternalGoal" => new EternalGoal(name, points),
                            "ChecklistGoal" => new ChecklistGoal(name, points, 5, 500),
                            "StreakGoal" => new StreakGoal(name, points, 10),
                            "NegativeGoal" => new NegativeGoal(name, points),
                            _ => null
                        };

                        if (goal != null)
                        {
                            if (isCompleted) goal.RecordProgress(); // Restore completion state
                            AddGoal(goal);
                        }
                    }
                }
            }
            Console.WriteLine("📂 Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("⚠️ No saved goals found.");
        }
    }
}
