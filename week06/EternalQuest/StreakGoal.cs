public class StreakGoal : Goal
{
    private int streakCount;
    private int streakBonus;

    public StreakGoal(string name, int points, int streakBonus) : base(name, points)
    {
        this.streakBonus = streakBonus;
        this.streakCount = 0;
    }

    public override int RecordProgress()
    {
        streakCount++;
        return Points + (streakCount * streakBonus);
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ {(IsCompleted ? "X" : " ")} ] {Name} - Current Streak: {streakCount} days ({Points} points)");
    }
}
