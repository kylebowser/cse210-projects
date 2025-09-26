using System;

class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public void Display()
    {
        string text = _author;
        Console.WriteLine($"Comment Author: {_author}");
        Console.WriteLine(_text);
    }
}