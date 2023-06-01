public class Loanable{
    protected bool _isCheckedIn = true;
    protected string _title="";

    public void CheckOut(){
        _isCheckedIn = false;
    }

    public void CheckIn(){
        _isCheckedIn = true;
    }

    public virtual void Display(){
        Console.WriteLine($"Available: {_isCheckedIn}");
    }
}