using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to drink water?", "Waterboy123", 154);
        Video video2 = new Video("Relaxing music", "Pam Pamboy", 300);
        Video video3 = new Video("Gameplay: Witcher 3 episode 5", "Waterboy123", 660);
        Video video4 = new Video("Dog barks at postman 3", "Jim", 15);

        video1.AddComment("Yaboi555", "Great vid bud");
        video1.AddComment("Johny", "Nice");
        video1.AddComment("TheBobMan", "Enjoyed");

        video2.AddComment("YellowLemon", "e");
        video2.AddComment("Sl33pyB0y", "Awesome music!");
        video2.AddComment("Tom", "Helped me relax");
        video2.AddComment("Yaboi555", "Boring!!!");

        video3.AddComment("Yaboi555", "I love Witcher");
        video3.AddComment("Sl33pyB0y", "Wither 2 is better");
        video3.AddComment("TheBobMan", "Just Subscribed");
        video3.AddComment("YellowLemon", "Can't wait for the next video!");

        video4.AddComment("YellowLemon", "Good boi");
        video4.AddComment("Yaboi555", "What is the breed?");
        video4.AddComment("Jim", "Dog thanks for your support!");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------");
            video.DisplayInfo();
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}