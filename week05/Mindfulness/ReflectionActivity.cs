public class ReflectionActivity : MindfulnessActivity
{
    private static List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "What did you learn from this experience?"
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on moments of strength.") {}

    public void Run()
    {
        StartActivity();
        var availablePrompts = new List<string>(prompts);
        Random rand = new Random();

        while (availablePrompts.Any())
        {
            string prompt = availablePrompts[rand.Next(availablePrompts.Count)];
            Console.WriteLine(prompt);
            availablePrompts.Remove(prompt);
            Thread.Sleep(5000);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            Thread.Sleep(5000);
        }

        EndActivity();
    }
}
