public class Menu{
    public void WelcomeUser(){
        Console.WriteLine("Welcome");
    }
    public Activity PromptNewActivity(){
        Console.WriteLine("How long would you like to do an activity today? (please enter the minutes)");
        int duration =  Convert.ToInt32(Console.ReadLine())*60;

        Console.WriteLine("Please choose a new Activity: \n[B]reathing\n[R]eflection\n[L]isting");
        string input = Console.ReadLine().ToLower();
        switch(input){
            case "b":
                return new BreathingActivity(duration);
            case "r":
                return new ReflectionActivity(duration);
            case "l":
                return new ListingActivity(duration);
            default:
                break;
        }
        return null;
    }
}