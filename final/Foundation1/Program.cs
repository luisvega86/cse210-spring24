public class Program
{
    public static void Main()
    {
        Video video1 = new Video("Abstraction", "AbsDev123", 300);
        video1.AddComment(new Comment("User A", "Great video!"));
        video1.AddComment(new Comment("User B", "Very informative."));
        video1.AddComment(new Comment("User C", "Thanks for sharing."));

        Video video2 = new Video("Encapsulation", "DevTeam88", 450);
        video2.AddComment(new Comment("User D", "Loved it!"));
        video2.AddComment(new Comment("User E", "Nice tutorial."));
        video2.AddComment(new Comment("User F", "Helped me a lot."));

        Video video3 = new Video("Inheritance", "EzCode", 360);
        video3.AddComment(new Comment("User G", "Interesting topic."));
        video3.AddComment(new Comment("User H", "Well explained."));
        video3.AddComment(new Comment("User I", "Good content."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}