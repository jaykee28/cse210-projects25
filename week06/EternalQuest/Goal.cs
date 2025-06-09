using System;

public abstract class Goal
{
    public string Name { get; protected set; }  // Accessible outside but modifiable only within class
    protected int Points;
    protected bool IsCompleted;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    // Getter method to ensure controlled access to Points
    public int GetPoints() => Points;

    // Abstract method for progress tracking (formerly RecordEvent)
    public abstract int RecordProgress();  

    // Returns goal status for display
    public virtual string GetStatus()
    {
        return IsCompleted ? "[X] Completed" : "[ ] In Progress";
    }

    // Displays goal details
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{GetStatus()} {Name} ({GetPoints()} points)");
    }
}
