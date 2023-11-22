using System.Transactions;

public class Video {
    public string _title;
    public string _author;
    public int _length;
    public List<Comments> _comments;

    public Video(string title, string author, int length, List<Comments> comments)

    {
        
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
        
    }

   

    public int GetTotalComments(List<Comments> comments)
    {
        int totalNumber = comments.Count;
        return totalNumber;

    }

    public void ShowVideo()
    {
        Console.WriteLine($"\nTitle: {_title} - Length: {_length} seconds by {_author}\nNumber of Comments: {GetTotalComments(_comments)}");
        Console.WriteLine("\nComments: ");

        foreach (Comments comment in _comments)
        {
            comment.GetComments();
        }
    }

    

}