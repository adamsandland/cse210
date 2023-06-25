public class SimpleGoal:Goal{

    string _item;
    string type = "simple";
    public SimpleGoal(string item, int pointValue){
        _item=item;
        base._pointWorth = pointValue;
    }
    public override void GoalAccomplished(bool finished)
    {
        base.GoalAccomplished(finished);
        base._taskAccomplished=true;
    }
    public override string GetItem(){ return _item; }
    public override string returnType(){ return type; }
}