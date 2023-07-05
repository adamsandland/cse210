public class Video{
    private List<Comment> _VideoComments;
    private string _title, _author;
    private int _duration;
    public Video(string title, string author, int duration){
        _title=title;
        _author=author;
        _duration=duration;
        _VideoComments = new List<Comment>();
    }
    public void AddComment(string comment, string username){
        _VideoComments.Add(new Comment(DateTime.Now, comment, username));
    }
    public void DisplayVideoAndContents(){
        Console.WriteLine($"{_title}\n{_author}\n\nComments:");
        foreach (var item in _VideoComments)
        {
            Console.WriteLine($"{item.FormattedComment()}");
        }
        Console.WriteLine($"\n\n");
    }
}