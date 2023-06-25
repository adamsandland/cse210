public class Goal{
    protected int _pointWorth;
    protected bool _taskAccomplished = false;
    protected int _timesAccomplished = 0;
    public virtual void GoalAccomplished(bool finished){
        _taskAccomplished=finished;
    }
    public virtual int RedeemAward(){ 
        if(_taskAccomplished){
            return _pointWorth;
        }
        return 0;
    }
    public virtual string GetItem(){
        return "";
    }
    public virtual string returnType(){ return "simple";}
    public virtual int GetTimesCompleted(){ return 0; }
    public virtual int GetTimesToComplete(){ return 0; }
    public int GetPointWorth(){ return _pointWorth; }
    public virtual void incrementCompleted(){
        _timesAccomplished++;
    }
}