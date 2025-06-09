public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        currentCount = 0;
    }

    public override int RecordProgress()
    {
        currentCount++;
        if (currentCount >= targetCount)
        {
            IsCompleted = true;
            return Points + bonusPoints;
        }
        return Points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ {(IsCompleted ? "X" : " ")} ] {Name} - Completed {currentCount}/{targetCount} times ({Points} points)");
    }
}
