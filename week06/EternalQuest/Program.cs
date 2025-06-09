using System;

class Program
{
    static void Main()
    {
        string saveFile = "goals.txt";

        // Initialize QuestManager & Load Previous Progress
        GoalManager goalManager = new GoalManager("Jacqueline");
        goalManager.LoadGoals(saveFile);

        Console.WriteLine("\nWelcome to the Eternal Quest Tracker!");
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record Goal Completion");
            Console.WriteLine("3. Add New Goal");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    goalManager.DisplayGoals();
                    break;

                case "2":
                    Console.Write("\nEnter goal name to record completion: ");
                    string goalName = Console.ReadLine();
                    goalManager.RecordEvent(goalName);
                    Console.WriteLine("\n🎖 Player Progress Updated!");
                    goalManager.DisplayPlayerStatus(); // Show updated rewards
                    break;

                case "3":
                    AddGoal addGoal = new AddGoal(goalManager);
                    addGoal.CreateNewGoal();
                    break;

                case "4":
                    goalManager.SaveGoals(saveFile);
                    Console.WriteLine("📂 Progress saved successfully!");
                    break;

                case "5":
                    goalManager.SaveGoals(saveFile); // Auto-save before exit
                    Console.WriteLine("✅ Progress saved. Exiting Eternal Quest.");
                    running = false;
                    break;

                default:
                    Console.WriteLine("⚠️ Invalid option. Please select a valid number.");
                    break;
            }
        }
    }
}
