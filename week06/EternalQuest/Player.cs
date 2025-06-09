using System;

public class Player
{
    public string Name { get; private set; }
    public int Score { get; private set; }
    public int Level { get; private set; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
        Level = 1;
    }

    // Adds points and updates level
    public void AddPoints(int points)
    {
        Score += points;
        UpdateLevel();
    }

    // Calculates level based on score thresholds
    private void UpdateLevel()
    {
        Level = Score / 500 + 1; // Example: Every 500 points = Level Up
    }

    // Displays player status
    public void DisplayStatus()
    {
        Console.WriteLine($"\n🎮 Player: {Name}");
        Console.WriteLine($"🏆 Score: {Score}");
        Console.WriteLine($"🔹 Level: {Level}");
        Console.WriteLine($"🎖 Title: {RewardSystem.GetTitle(Level)}");
        Console.WriteLine($"🏅 Trophy: {RewardSystem.GetTrophy(Score)}");
    }

    // Allows score restoration when loading saved progress
    public void SetScore(int score)
    {
        Score = score;
        UpdateLevel();
    }
}
