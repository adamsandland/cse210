public class Menu{
    public Menu(string reference, string scripture){
        Console.WriteLine($"Here is your scripture: {reference}\n{scripture}\n[H]ide next word\n[R]eveal last word\n[E]xit");
    }
    public void UpdateScreen(string reference, string scripture){
        Console.Clear();
        Console.WriteLine($"Here is your scripture: {reference}\n{scripture}\n[H]ide next word\n[R]eveal last word\n[E]xit");
    }
    public string WaitOnResponse(){
        string response = Console.ReadLine();
        switch(response){
            case "h":
                return "h";
            case "r":
                return "r";
            case "e":
                return "e";
            default:
                return "err";
        }
    }
    
}