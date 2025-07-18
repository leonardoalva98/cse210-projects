
// DESCRIPTION OF THE PROGRESS:
// Both programs, foundation 1 and 2 are completed.

public static class Program
{
    public static void Main()
    {
        var video1 = new Video("2024 BMW M4 Competition Review", "CarEnthusiast101", 720);
        var video2 = new Video("Tesla Model S Plaid Test Drive", "EVReviewer", 650);
        var video3 = new Video("Toyota Supra vs Nissan Z - Drag Race", "TrackMasters", 580);
        var video4 = new Video("Top 5 Sports Cars Under $50K", "AutoAdvisor", 480);

        video1.AddComment(new Comment("Leo", "This car sounds amazing!"));
        video1.AddComment(new Comment("Valeria", "Wish I could afford one."));
        video1.AddComment(new Comment("Nico", "Thanks for the detailed breakdown!"));

        video2.AddComment(new Comment("Riley", "Insane acceleration!"));
        video2.AddComment(new Comment("Sam", "Can't wait for mine to arrive."));
        video2.AddComment(new Comment("Marco", "What a beast of a car."));

        video3.AddComment(new Comment("Jordan", "Supra all the way!"));
        video3.AddComment(new Comment("Chris", "Nissan Z really impressed me."));
        video3.AddComment(new Comment("Alexander", "Loved the slow-mo replay."));

        video4.AddComment(new Comment("Katy", "Awesome list, very helpful!"));
        video4.AddComment(new Comment("Jamie", "Can you do sedans next?"));
        video4.AddComment(new Comment("Sofia", "I want that Mustang now."));

        var videos = new List<Video> { video1, video2, video3, video4 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title:  {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  • {comment.Author}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}