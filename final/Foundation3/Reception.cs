public class Reception:Event{
    private string rsvp_address;
    public Reception(string rsvp, string title, string description, string time, string address, DateTime date) : base( title, description, time, address, date){
        rsvp_address=rsvp;
    }
    public override string GenerateDetails(int std_full_desc)
    {
        if(std_full_desc==0){
            return $"{base._title}\n{base._description}\n{base._date.Date}\n{base._time}\n{base._address}";
        }else if(std_full_desc==1){
            return $"{base._title}\n{base._description}\n{base._date.Date}\n{base._time}\n{base._address}\nReception, RSVP @ {rsvp_address}";
        }else if(std_full_desc==2){
            return $"Reception\n{base._title}\n{base._date.Date}";
        }else{
            return null;
        }
    }
}