public class Comment{
    private string _timestamp, _comment, _username;
    public Comment(DateTime time, string comment, string username){
        _timestamp = time.ToString("MMMM dd, yyyy, H:mm");
        _comment=comment;
        _username=username;
    }
    public string GetTimestamp(){ return _timestamp; }
    public string GetComment(){ return _comment; }
    public string GetUsername(){ return _username; }
    public string FormattedComment(){
        return $"{_username} on {_timestamp}:\n    {_comment}";
    }
}