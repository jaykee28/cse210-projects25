public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    // Records the goal as completed and awards points
    public override int RecordProgress()
    {
        IsCompleted = true;
        return Points;
    }

    // Displays goal status
    public override void DisplayGoal()
    {
        Console.WriteLine($"[ {(IsCompleted ? "X" : " ")} ] {Name} - {Points} points");
    }
}
