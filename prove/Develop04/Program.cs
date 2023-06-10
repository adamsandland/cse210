using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();
        List<Activity> activities = new List<Activity>();

        mainMenu.WelcomeUser();
        Activity choice = mainMenu.PromptNewActivity();
        if(choice!=null){
            choice.ActivityStart();
        }
    }
}