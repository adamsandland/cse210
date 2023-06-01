public class Assignment{
    protected string _studentName;
    protected string _topic;
    public Assignment(){

    }
    public string GetSummary(){
        return $"Name: {_studentName} Topic: {_topic}";
    }
}