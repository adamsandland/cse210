public class Activity{
    protected int _durationOfActivity =0;
    protected string _activityName = "";
    protected string _activityDescription = "";
    protected int _timeElapsed=0;
    public virtual void ActivityStart(){
        _timeElapsed = 0;
        Console.Clear();
        Console.WriteLine($"The Name of this activity is {_activityName}.\nIn this activity, you will be {_activityDescription}.\n");
        
    }

    public void ActivityEnd(){
        Console.WriteLine($"Congratulations! You've finished the activity for today.\nCome back again tomorrow!");
    }
    public void DisplayWaitingAnim(int time, string message){
        int i = 0;
        Console.Clear();
        Console.WriteLine(message);
        while(i<time)
        {
            Console.WriteLine($"{time-i}");
            Thread.Sleep(1000);
            i++;
        }
    }
    protected bool CheckForTimeLimit(int timeElapsed){
        if(timeElapsed>=_durationOfActivity){
            return true;
        }else{
            return false;
        }
    }
    protected void Wait(int timeInSec){
        Thread.Sleep(1000*timeInSec);
        _timeElapsed+=timeInSec;
    }

}