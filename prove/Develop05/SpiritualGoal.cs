public class SpiritualGoal:Goal{
    bool _dailyProgress;
    string _item;
    string type = "eternal";
    public SpiritualGoal(string item, int pointValue){
        _item=item;
        base._pointWorth = pointValue;
    }
    public override void GoalAccomplished(bool finished)
    {
        base.GoalAccomplished(finished);

    }
    public void ProgressMade(bool isit, DateTime now){
        if(now.Day==DateTime.Now.Day){
            _dailyProgress=true;
        }
        else{
            _dailyProgress=false;
        }
    }
    public override string GetItem(){ return _item; }
    public override string returnType(){ return type; }
}