public class Prompt{
    private List<string> oldPrompts = new List<string>();
    private List<string> remainingPrompts = new List<string>();
    
    public void AddPrompt(string newPrompt){
        remainingPrompts.Add(newPrompt);
    }
    public string GetNextPrompt(){
        string nextprompt = remainingPrompts[0];
        oldPrompts.Add(remainingPrompts[0]);
        return nextprompt;
    }
    public string GetRandomPrompt(){
        Random rand = new Random();
        int value = rand.Next(0,remainingPrompts.Count);
        return remainingPrompts[value];
    }
    public void PropmtUsed(string prompt){
        
    }
}