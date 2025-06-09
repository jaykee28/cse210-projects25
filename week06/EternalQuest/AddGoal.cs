using System;

public class AddGoal
{
    private GoalManager goalManager;

    public AddGoal(GoalManager manager)
    {
        goalManager = manager;
    }

    public void CreateNewGoal()
    {
        Console.Write("\nEnter the name of your new goal: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter points earned per completion: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Streak Goal");
        Console.WriteLine("5. Negative Goal");
        Console.Write("Enter choice (1-5): ");
        string goalType = Console.ReadLine();

        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(goalName, points);
                break;
            case "2":
                newGoal = new EternalGoal(goalName, points);
                break;
            case "3":
                Console.Write("Enter target count for checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completion: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(goalName, points, targetCount, bonusPoints);
                break;
            case "4":
                Console.Write("Enter streak bonus per consecutive completion: ");
                int streakBonus = int.Parse(Console.ReadLine());
                newGoal = new StreakGoal(goalName, points, streakBonus);
                break;
            case "5":
                newGoal = new NegativeGoal(goalName, points);
                break;
            default:
                Console.WriteLine("⚠️ Invalid selection. Please try again.");
                return;
        }

        goalManager.AddGoal(newGoal);
        Console.WriteLine($"✅ New goal '{goalName}' added successfully!");
    }
}
