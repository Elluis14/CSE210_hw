using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Introduction to C#", "Luis Ramos", 600);
        video1.AddComment(new Comment("Alice", "Great video, very helpful!"));
        video1.AddComment(new Comment("Bob", "Thank you for explaining it clearly."));
        video1.AddComment(new Comment("Carol", "I learned a lot from this."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Object-Oriented Programming", "Luis Ramos", 750);
        video2.AddComment(new Comment("David", "Encapsulation is clearer now."));
        video2.AddComment(new Comment("Eva", "Can you make a video on inheritance?"));
        video2.AddComment(new Comment("Frank", "This was exactly what I needed."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Advanced C# Techniques", "Luis Ramos", 900);
        video3.AddComment(new Comment("Grace", "LINQ is awesome!"));
        video3.AddComment(new Comment("Henry", "Your examples are very clear."));
        video3.AddComment(new Comment("Irene", "Thank you for this advanced topic!"));
        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
