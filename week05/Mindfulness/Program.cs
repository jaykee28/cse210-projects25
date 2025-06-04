class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Visualization");
            Console.WriteLine("5. View Log");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ReflectionActivity().Run();
            else if (choice == "3") new ListingActivity().Run();
            else if (choice == "4") new VisualizationActivity().Run();
            else if (choice == "5") DisplayLog();
            else if (choice == "6") break;
            else Console.WriteLine("Invalid choice.");
        }
    }

    static void DisplayLog()
    {
        if (File.Exists("MindfulnessLog.txt"))
        {
            Console.WriteLine("\nMindfulness Activity Log:");
            Console.WriteLine(File.ReadAllText("MindfulnessLog.txt"));
        }
        else
        {
            Console.WriteLine("\nNo activities logged yet.");
        }
    }
}
