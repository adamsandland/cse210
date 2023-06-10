public class ReflectionActivity:Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _reflections = new List<string>();

    public ReflectionActivity(int duration){
        base._activityName = "Reflection Activity";
        base._activityDescription = "helping you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
        base._durationOfActivity = duration;
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _reflections.Add("Why was this experience meaningful to you?");
        _reflections.Add("Have you ever done anything like this before?");
        _reflections.Add("How did you get started?");
        _reflections.Add("How did you feel when it was complete?");
        _reflections.Add("What made this time different than other times when you were not as successful?");
        _reflections.Add("What is your favorite thing about this experience?");
        _reflections.Add("What could you learn from this experience that applies to other situations?");
        _reflections.Add("What did you learn about yourself through this experience?");
        _reflections.Add("How can you keep this experience in mind in the future?");
    }
    public override void ActivityStart()
    {
        base.ActivityStart();
        DisplayRandomPrompt();
        DisplayReflectionOfActivity();
    }
    public void DisplayRandomPrompt(){
        Random rand = new Random();
        Console.WriteLine($"Here is your prompt for today:\n{_prompts[rand.Next(0,4)]}");
        base.Wait(20);
        base._timeElapsed=10;

    }
    public void DisplayReflectionOfActivity(){
        int i =  0;
        while(i<_reflections.Count){
            if(!base.CheckForTimeLimit(base._timeElapsed)){
                Console.Clear();
                Console.WriteLine($"Take a few moments to reflect:\n{_reflections[i]}");
                base.Wait(15);
            }
            i++;
        }
        base.ActivityEnd();

    }
}