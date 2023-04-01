using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("Sole Iris", "Don't watch this at 2am", 4000));
        videos.Add(new Video("QQQ", "Castle Quest TAS 4:54", 301));
        videos.Add(new Video("", "Pet Compilation #32", 700));
        videos[0].AddComment("Josh", "I wonder where this was filmed at");
        videos[0].AddComment("Katie", "The jumpscare at 10:36 lol");
        videos[0].AddComment("Shawn", "A little disappointed that this wasn't a psychological thriller, but at least it wasn't that bad.");
        videos[1].AddComment("Aaron", "I didn't imagine this game could be obliterated like this! Now I know.");
        videos[1].AddComment("Michael", "Is that even humanly possible?");
        videos[1].AddComment("Jay", "What's causing the frame rates to drop");
        videos[2].AddComment("Nick", "1:03 lol");
        videos[2].AddComment("Sean", "That cat looked so confused");
        videos[2].AddComment("Abby", "This video has the widest range of animals that I've ever seen");
        foreach(Video v in videos)
        {
            PrintVideoComments(v);
        }
    }
    static void PrintVideoComments(Video video)
    {
        Console.WriteLine($"Video Title: {video.GetTitle()}");
        Console.WriteLine($"By: {video.GetAuthor()}");
        Console.WriteLine($"Video Length: {video.GetVideoLength()}"); 
        Console.WriteLine($"Comment Count: {video.ReturnCommentListLength()}");
        List<Comment> comments = new List<Comment>();

        comments = video.ReturnCommentList();
        for(int i = 0; i < video.ReturnCommentListLength(); i++)
        {
            Console.WriteLine($"    {comments[i].GetComment()}");
        }
        Console.WriteLine();
    }
}