public class Event{
    protected string _title, _description, _time, _address;
    protected DateTime _date;
    public Event(string title, string description, string time, string address, DateTime date){
        _title=title;
        _description=description;
        _time=time;
        _address=address;
        _date=date;
    }
    public string GetTitle(){ return _title; }
    public string GetDescription(){ return _description; }
    public DateTime GetDate(){ return _date; }
    public virtual string GenerateDetails(int std_full_desc){ return null;}
}