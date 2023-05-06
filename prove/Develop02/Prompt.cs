public class Prompt
{
    List<string> _prompts = new List<string>();
    List<string> _usedPrompts = new List<string>();
    public Prompt()
    {
        _prompts.Add("How was your day?");
    }

    public string GetRandomPrompt()
    {
        return "Prompt";
    }
}