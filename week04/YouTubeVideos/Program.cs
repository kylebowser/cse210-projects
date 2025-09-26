using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video1", "Video1 Author", 12345);
        video1.SetComment("Commenter 1", "This is the first comment!");
        video1.SetComment("Commenter 2", "Whoa what a video!");
        video1.SetComment("Commenter 3", "First!");

        videos.Add(video1);

        Video video2 = new Video("Video2", "Video2 Author", 567689);
        video2.SetComment("Commenter 21", "Dang!");
        video2.SetComment("Commenter 22", "Greetings from Australia!");
        video2.SetComment("Commenter 23", "Seen it...");

        videos.Add(video2);

        Video video3 = new Video("Video3", "Video3 Author", 97643);
        video3.SetComment("Commenter 31", "Its not that good");
        video3.SetComment("Commenter 32", "This is my favorit!");
        video3.SetComment("Commenter 33", "Anyone still here in 2025?");

        videos.Add(video3);

        Console.WriteLine("Video Summaries: ");
        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.Dispaly();
        }
    }
}