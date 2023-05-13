public class Entry{
    private List<Prompt> _prompts = new List<Prompt>();
    private string _entry;
    private string _date;

    public Entry(string date, string entry){
        //establish all private variables
        _date = date;
        _entry = entry;

    }
    public string Display(){
        return $"{_date}:\n{_entry}";
    }
    public string GetUserEntry(){return _entry;}
    public string GetDate(){return _date;}
    public void OverWriteEntry(string newDate, string newEntry){_date = newDate;_entry = newEntry;}
    
}