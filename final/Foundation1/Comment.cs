using System;

public class Comment
{
    public string _ASname;
    public string _AScommentText;

    public void DisplayComment()
    {
        Console.WriteLine($" - {_ASname}: {_AScommentText}");
    }
}