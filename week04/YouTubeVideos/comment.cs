public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public void Display()
    {
        Console.WriteLine($"Comment by {_commenterName}: {_commentText}");
        
    }

}