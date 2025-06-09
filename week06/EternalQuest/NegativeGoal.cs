public class NegativeGoal : Goal
{
    private int penaltyPoints;

    public NegativeGoal(string name, int penaltyPoints) : base(name, -penaltyPoints)
    {
        this.penaltyPoints = penaltyPoints;
    }

    public override int RecordProgress()
    {
        return -penaltyPoints; // Deduct points for bad habits
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ {(IsCompleted ? "X" : " ")} ] {Name} - Penalty: {penaltyPoints} points");
    }
}
