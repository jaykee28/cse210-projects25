public class RewardSystem
{
    public static string GetTitle(int level)
    {
        if (level >= 10) return "Legendary Quest Master";
        if (level >= 5) return "Champion of Growth";
        return "Aspiring Adventurer";
    }

    public static string GetTrophy(int score)
    {
        if (score >= 5000) return "🏆 Golden Crown";
        if (score >= 2500) return "⭐ Silver Star";
        return "🎖 Bronze Badge";
    }
}
