using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void SetComment(string author, string comment)
    {
        Comment comment1 = new Comment(author, comment);
        _comments.Add(comment1);
    }

    internal int GetCommentNumber()
    {
        return _comments.Count();
    }

    public void Dispaly()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} Seconds");
        Console.WriteLine($"Nubmer of Comments: {GetCommentNumber()}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        } 
    }
}