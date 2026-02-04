using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Zomac Digital", 600);
        video1.AddComment(new Comment("Wishy", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "This cleared my confusion."));
        videos.Add(video1);

        Video video2 = new Video("OOP Principles", "Tech Charities", 720);
        video2.AddComment(new Comment("Takudzwa", "Nice examples."));
        video2.AddComment(new Comment("Prince", "Abstraction makes sense now."));
        video2.AddComment(new Comment("Frank", "Well presented."));
        videos.Add(video2);

        Video video3 = new Video("C# Classes Tutorial", "Programming Hub", 540);
        video3.AddComment(new Comment("Grace", "Simple and clear."));
        video3.AddComment(new Comment("Henry", "Perfect for beginners."));
        video3.AddComment(new Comment("Ivy", "Loved this tutorial."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
