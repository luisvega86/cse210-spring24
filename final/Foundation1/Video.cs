using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}.");
        Console.WriteLine($"Author: {_author}.");
        Console.WriteLine($"Lenght: {_length} sec.");
        Console.WriteLine($"Comments({_comments.Count}):");
        foreach (var item in _comments)
        {
            item.Display();
        }
        Console.WriteLine();
    }
}