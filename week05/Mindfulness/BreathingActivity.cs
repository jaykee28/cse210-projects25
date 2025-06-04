public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax through deep breathing.") {}

    public void Run()
    {
        StartActivity();
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine("      BREATHE IN...");
            Thread.Sleep(2000);
            Console.WriteLine("      B R E A T H E  I N...");
            Thread.Sleep(2000);
            Console.WriteLine("      Breathe Out...");
            Thread.Sleep(3000);
        }
        EndActivity();
    }
}
