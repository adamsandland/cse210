public class Outdoors:Event{
    private string _weather;
    public Outdoors(string weather, string title, string description, string time, string address, DateTime date) : base( title, description, time, address, date){
        _weather=weather;
    }
    public override string GenerateDetails(int std_full_desc)
    {
        if(std_full_desc==0){
            return $"{base._title}\n{base._description}\n{base._date.Date}\n{base._time}\n{base._address}";
        }else if(std_full_desc==1){
            return $"{base._title}\n{base._description}\n{base._date.Date}\n{base._time}\n{base._address}\nOutdoor Gathering, it will be {_weather}";
        }else if(std_full_desc==2){
            return $"Outdoors Event\n{base._title}\n{base._date.Date}";
        }else{
            return null;
        }
    }
}