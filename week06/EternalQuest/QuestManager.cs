public class QuestManager
{
    private List<Goal> goals = new List<Goal>();
    private Player player;
    public QuestManager(string playerName)
    {
        player = new Player(playerName);
    }
    private int totalScore = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                totalScore += goal.RecordProgress();
                Console.WriteLine($"Progress recorded for '{goalName}'! Total Score: {totalScore}");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
    }
}
