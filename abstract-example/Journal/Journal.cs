public class Journal{
    private List<Entry> _entries = new List<Entry>();
    private CSVLoader _accessControl = new CSVLoader();
    private Prompt todaysPrompt = new Prompt();
    private string _filePath;

    public Journal(string filePath){
        _accessControl.load(filePath);
        _filePath=filePath;
        _entries = _accessControl.ReturnContents();
        todaysPrompt.AddPrompt("How was school?");
        todaysPrompt.AddPrompt("How was your day?");
        todaysPrompt.AddPrompt("What was your favorite part about the day?");
        todaysPrompt.AddPrompt("What was something cool you did?");
        todaysPrompt.AddPrompt("Who was someone you liked being near today?");
        todaysPrompt.AddPrompt("In what ways have you improved?");
    }
    public void Display(){

    }
    public void NewEntry(Entry addEntry){
        _entries.Add(addEntry);
    }
    public void SortEntries(string byValue){
        if(byValue == "date"){
            //sort the entries by date
        }
    }
    public void ViewEntries(){
        foreach(Entry entry in _entries){
            Console.WriteLine($"{entry.Display()}\n");
        }
    }
    public void WriteEntries(){
        _accessControl.overwrite(_filePath, _entries);
    }
    public string TodaysPrompt(string type=""){
        if(type=="random"){
            return todaysPrompt.GetRandomPrompt();
        }else{
            return todaysPrompt.GetNextPrompt();
        }
    }
}