using System;
using System.Collections.Generic;

namespace YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Programming Basics", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "This helped me a lot."));
        video1.AddComment(new Comment("Charlie", "When is part 2 coming?"));
        video1.AddComment(new Comment("Diana", "Clear explanation, thanks!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Learn Abstraction in 10 Minutes", "TechTeacher", 620);
        video2.AddComment(new Comment("Eve", "Abstraction finally makes sense!"));
        video2.AddComment(new Comment("Frank", "Short and sweet."));
        video2.AddComment(new Comment("Grace", "Examples were perfect."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Top 5 Coding Mistakes", "DevGuru", 480);
        video3.AddComment(new Comment("Hank", "I made mistake #3 yesterday"));
        video3.AddComment(new Comment("Ivy", "Very helpful tips"));
        video3.AddComment(new Comment("Jack", "Subscribed!"));
        video3.AddComment(new Comment("Kelly", "Quality content"));
        videos.Add(video3);

        // Video 4 (optional extra)
        Video video4 = new Video("OOP Explained Simply", "CodeWithJoy", 540);
        video4.AddComment(new Comment("Leo", "Best OOP video ever"));
        video4.AddComment(new Comment("Mia", "The examples were relatable"));
        video4.AddComment(new Comment("Noah", "I finally get it"));
        videos.Add(video4);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}