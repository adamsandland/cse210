public class Lecture:Event{
    private string _speakerName;
    private int _capacity;
    public Lecture(string speakerName, int capacity, string title, string description, string time, string address, DateTime date) : base( title, description, time, address, date){
        _speakerName=speakerName;
        _capacity=capacity;
    }
    public override string GenerateDetails(int std_full_desc)
    {
        if(std_full_desc==0){
            return $"{base._title}\n{base._description}\n{base._date.Date}\n{base._time}\n{base._address}";
        }else if(std_full_desc==1){
            return $"{base._title}\n{base._description}\n{base._date.Date}\n{base._time}\n{base._address}\nLecture by {_speakerName}, {_capacity} seats available.";
        }else if(std_full_desc==2){
            return $"Lecture\n{base._title}\n{base._date.Date}";
        }else{
            return null;
        }
    }
}