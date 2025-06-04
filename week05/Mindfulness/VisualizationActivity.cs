public class VisualizationActivity : MindfulnessActivity
{
    private static List<string> scenarios = new List<string>
    {
        "Imagine yourself in a peaceful forest, listening to the sounds of nature.",
        "Picture yourself achieving a personal goal and feeling proud."
    };

    public VisualizationActivity() : base("Visualization", "This activity helps you visualize peaceful or inspiring moments.") {}

    public void Run()
    {
        StartActivity();
        Random rand = new Random();

        Console.WriteLine(scenarios[rand.Next(scenarios.Count)]);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Focus on the details of the scene...");
            Thread.Sleep(5000);
        }

        EndActivity();
    }
}

