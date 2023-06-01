public class WritingAssignment:Assignment{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title){
        base._studentName = studentName;
        base._topic = topic;
        _title=title;
    }
    public string GetWritingInformation(){
        return $"{_title} by {base._studentName}";
    }
}