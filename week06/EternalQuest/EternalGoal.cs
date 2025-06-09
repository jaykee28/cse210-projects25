public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override int RecordProgress()
    {
        return Points;
    }
}
