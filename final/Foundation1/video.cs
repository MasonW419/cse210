using System;

class Video
{
    private string _author;
    private string _title;
    private int _videoLength;
    private List<Comment> _commentList;
    
    public Video(string author, string title, int videoLength)
    {
        _author = author;
        _title = title;
        _videoLength = videoLength;
        _commentList = new List<Comment>();
    }
    public void AddComment(string author, string text)
    {
        _commentList.Add(new Comment(author, text));
    }
    public int ReturnCommentListLength()
    {
        return _commentList.Count();
    }
    public List<Comment> ReturnCommentList()
    {
        return _commentList;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public int GetVideoLength()
    {
        return _videoLength;
    }
}