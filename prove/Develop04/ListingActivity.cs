public class ListingActivity:Activity{
    private List<string> _prompts = new List<string>();
    private List<string> records = new List<string>();
    public ListingActivity(int duration){
        base._activityName = "Listing Activity";
        base._activityDescription = "helping you reflect on the good things in your life through listing as many things as you can in a certain area";
        base._durationOfActivity = duration;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public override void ActivityStart()
    {
        base.ActivityStart();
        DisplayRandomPrompt();
        RecordInput();
        Console.Clear();
        Console.WriteLine("Great job! Here are all the items you listed:");
        foreach(string item in records){
            Console.WriteLine(item);
        }
        base.ActivityEnd();
        

    }
    public void RecordInput(){
        Console.Clear();
        
        long startTime = DateTime.Now.Ticks;
        while(!CheckForTimeLimit(base._timeElapsed)){
            records.Add(Console.ReadLine());
            double secondsElapsed = new TimeSpan(DateTime.Now.Ticks - startTime).TotalSeconds;
            base._timeElapsed+=Convert.ToInt32(secondsElapsed);
        }

    }
    public void DisplayRandomPrompt(){
        Random rand = new Random();
        Console.WriteLine($"Here is your prompt for today:\n{_prompts[rand.Next(0,4)]}");
        base.Wait(10);
    }
}