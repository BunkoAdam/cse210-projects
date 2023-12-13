using System;

public class Video
{
    public string _AStitle;
    public string _ASauthor;
    public string _ASlength;
    public List<Comment> _AScommentList = new List<Comment>();

    public void ASDisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_AStitle}");
        Console.WriteLine($"Author: {_ASauthor}");
        Console.WriteLine($"Length: {_ASlength} seconds");
        int AScommentCount = _AScommentList.Count();
        Console.WriteLine($"Comments ({AScommentCount}):");

        foreach (Comment AScomment in _AScommentList)
        {
            AScomment.DisplayComment();
        }

    }
}