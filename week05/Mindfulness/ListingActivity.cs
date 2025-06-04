public class ListingActivity : MindfulnessActivity
{
    private static List<string> prompts = new List<string>
    {
        "List people you appreciate.",
        "List personal strengths of yours."
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect on positive things.") {}

    public void Run()
    {
        StartActivity();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Thread.Sleep(5000);

        Console.WriteLine("Start listing items...");
        List<string> items = new List<string>();

        while (true)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item)) break;
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();
    }
}
