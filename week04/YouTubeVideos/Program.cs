class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Basics", "Programming Academy", 600);
        video1.AddComment(new Comment("Albert", "Great tutorial!"));
        video1.AddComment(new Comment("Mike", "Very helpful."));
        video1.AddComment(new Comment("Patie", "Clear explanations!"));

        Video video2 = new Video("Python Programming For Beginners", "Jacqueline Mufetu", 750);
        video2.AddComment(new Comment("Jackie", "Python finally makes sense!"));
        video2.AddComment(new Comment("Emma", "Concise and informative."));
        video2.AddComment(new Comment("Lori", "Loved this video!"));

        Video video3 = new Video("Debugging Tips for Developers", "Albert Bungane", 500);
        video3.AddComment(new Comment("Grace", "Super useful tips!"));
        video3.AddComment(new Comment("Emmy", "I needed this."));
        video3.AddComment(new Comment("Renny", "Very insightful."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
