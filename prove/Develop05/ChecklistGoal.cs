public class ChecklistGoal:Goal{
    private int _timesToAccomplish;
    string _item;
    string type = "checklist";
    public ChecklistGoal(string item, int pointValue, int timesToAccomplish, int timesAccomplished){
        _item=item;
        base._pointWorth = pointValue;
        _timesToAccomplish=timesToAccomplish;
        base._timesAccomplished=timesAccomplished;
    }
    public override void GoalAccomplished(bool finished)
    {
        base.GoalAccomplished(finished);
    }
    public override int RedeemAward()
    {
        return base.RedeemAward();
    }
    public override string GetItem(){ return _item; }
    public override string returnType(){ return type; }
    public override int GetTimesCompleted(){ return base._timesAccomplished; }
    public override int GetTimesToComplete(){ return _timesToAccomplish; }
    
}