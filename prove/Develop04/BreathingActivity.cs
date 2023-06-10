public class BreathingActivity:Activity{
    private List<string> _AlternatingBreath = new List<string>();
    public BreathingActivity(int duration){
        base._activityName = "Breathing Activity";
        base._activityDescription = "walking you through relaxing by breathing in and out slowly.";
        base._durationOfActivity = duration;
    }
    public override void ActivityStart(){
        base.ActivityStart();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        base.DisplayWaitingAnim(3, "Clear your mind");
        while(!base.CheckForTimeLimit(base._timeElapsed)){
            TakeABreath();
        }
        base.ActivityEnd();
    }
    private void TakeABreath(){
        base.DisplayWaitingAnim(5, "Breathe in");
        base.DisplayWaitingAnim(10, "Breathe out slowly");
        base._timeElapsed+=13;
    }
    
}