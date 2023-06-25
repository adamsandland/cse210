public class Menu{
    List<Goal> _tempGoalList;
    User _activeUser;
    FileReader _activeFile;
    int _activeEntry=0;
    int itemInList=0;
    string _activeFileName;
    public Menu(string filename){
        _activeFileName = filename;
        _activeFile=new FileReader(filename);
        _tempGoalList = new List<Goal>();
        int sectionCount = 0;
        List<string> testing = _activeFile.GetFile();
        foreach (var item in testing)
        {   
            if(item=="**Username**"){
                sectionCount=0;
                itemInList=0;
            }else if(item=="**Simple**"){
                sectionCount=1;
                itemInList=0;
            }else if(item=="**Eternal**"){
                sectionCount=2;
                itemInList=0;
            }else if(item=="**Checklist**"){
                sectionCount=3;
                itemInList=0;
            }else if(item=="**Points**"){
                sectionCount=4;
                itemInList=0;
            }
            if(itemInList!=0){
                string[] splitValue;
                string theGoalText;
                int theGoalValue;
                int timesToFinish=0;
                int timesFinished =0;
                if(item.Contains(" || ")){
                    splitValue = item.Split(" || ");
                    theGoalText = splitValue[0];
                    theGoalValue = Int32.Parse(splitValue[1]);
                    if(splitValue.Count()>2){
                        timesToFinish = Int32.Parse(splitValue[2]);
                    }
                    if(splitValue.Count()>3){
                        timesFinished = Int32.Parse(splitValue[3]);
                    }
                }else{
                    theGoalText="";
                    theGoalValue=0;
                }
                switch(sectionCount){
                    case 0:
                        _activeUser = new User(_tempGoalList,theGoalText, theGoalValue);
                        break;
                    case 1:
                        _tempGoalList.Add(new SimpleGoal(theGoalText, theGoalValue));
                        break;
                    case 2:
                        _tempGoalList.Add(new SpiritualGoal(theGoalText, theGoalValue));
                        break;
                    case 3:
                        _tempGoalList.Add(new ChecklistGoal(theGoalText, theGoalValue, timesToFinish, timesFinished));
                        break;
                    case 4:
                        break;
                }   
            }
            itemInList+=1;
            
        }
        
        
        MainMenu(_activeUser);
    }
    public void MainMenu(User active){
        Console.Clear();
        while(true){
            active.DisplayPoints();
            Console.WriteLine($"Welcome {active.GetName()}, please select something you'd like to do:\n[V]iew Goals\n[C]reate new goal\n[M]ark goal as complete\n[E]xit");
            List<string> options = new List<string>();
            options.Add("v");options.Add("c");options.Add("m");options.Add("e");
            WaitForEntry(options, 0, null);
        }
        
    }
    public void CreateGoal(){
        Console.Clear();
        Console.WriteLine($"To create a goal, please enter in the type of Goal:\n[S]imple\n[E]ternal\n[C]hecklist");
        List<string> options = new List<string>();
        options.Add("s");options.Add("e");options.Add("c");
        WaitForEntry(options,1, null);
    }
    public void RecordEvent(){
        Console.Clear();
        Console.WriteLine($"To record an event, please select one (by number) from the list:");
        int counter = 0;
        foreach (var item in _tempGoalList)
        {
            Console.WriteLine($"{counter}: {item.GetItem()}");
            counter++;
        }
        int choice = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Where you able to finish the following task?\n{_tempGoalList[choice].GetItem()}\n(Y/n)");
        string confirm = Console.ReadLine();
        switch(confirm.ToLower()){
            case "y":
                _tempGoalList[choice].GoalAccomplished(true);
                _activeUser.UpdatePoints(_tempGoalList[choice].RedeemAward());
                if(_tempGoalList[choice].returnType()=="simple"){
                    _tempGoalList.RemoveAt(choice);
                }else if(_tempGoalList[choice].returnType()=="checklist"){
                    if(_tempGoalList[choice].GetTimesCompleted()>=_tempGoalList[choice].GetTimesToComplete()){
                        
                        _tempGoalList.RemoveAt(choice);
                    }else{
                        _tempGoalList[choice].incrementCompleted();
                    }
                }
                break;
            case "n":
                break;
        }
        
    }
    public void ListGoals(){
        Console.Clear();
        Console.WriteLine($"These are your current goals:");
        int counter = 0;
        foreach (var item in _tempGoalList)
        {
            Console.WriteLine($"{counter}: {item.GetItem()} ({item.GetType()})");
            counter++;
        }
    }
    public void WriteToSave(){
        List<string> fileOverwrite = new List<string>();
        List<string> simpleGoals = new List<string>();
        List<string> eternalGoals = new List<string>();
        List<string> checklistGoals = new List<string>();
        foreach (var item in _tempGoalList)
        {
            if(item.returnType()=="simple"){
                simpleGoals.Add($"{item.GetItem()} || {item.GetPointWorth()}");
            }else if(item.returnType()=="eternal"){
                eternalGoals.Add($"{item.GetItem()} || {item.GetPointWorth()}");
            }else if(item.returnType()=="checklist"){
                checklistGoals.Add($"{item.GetItem()} || {item.GetPointWorth()} || {item.GetTimesToComplete()} || {item.GetTimesCompleted()}");
            }
        }
        fileOverwrite.Add("**Username**");
        fileOverwrite.Add($"{_activeUser.GetName()} || {_activeUser.GetPoints()}");
        fileOverwrite.Add("**Simple**");
        foreach (var item in simpleGoals)
        {
            fileOverwrite.Add(item);
        }
        fileOverwrite.Add("**Eternal**");
        foreach (var item in eternalGoals)
        {
            fileOverwrite.Add(item);
        }
        fileOverwrite.Add("**Checklist**");
        foreach (var item in checklistGoals)
        {
            fileOverwrite.Add(item);
        }
        File.WriteAllLines(_activeFileName, fileOverwrite.ToArray());

    }
    public void ChooseOption(string selection, int menuNum, string choice){
        if(menuNum==0){
            switch(selection){
                case "v":
                    ListGoals();
                    break;
                case "c":
                    CreateGoal();
                    break;
                case "m":
                    RecordEvent();
                    break;
                case "e":
                    WriteToSave();
                    Environment.Exit(0);
                    break;
            } 
        }else if(menuNum==1){
            switch(selection){
                case "s":
                    SimpleActivity();
                    break;
                case "e":
                    EternalActivity();
                    break;
                case "c":
                    ChecklistActivity();
                    break;
            } 
        }

    }
    public void WaitForEntry(List<string> options, int menuNum, string choice){
        string entry = Console.ReadLine();
        if(options.Contains(entry.ToLower())){
            ChooseOption(entry, menuNum, choice);
        }else{
            WaitForEntry(options, menuNum, choice);
        }
    }
    public void SimpleActivity(){
        Console.Clear();
        Console.WriteLine("Please enter your simple goal:");
        string newGoal = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("How many points is this activity worth?");
        int pointValue = Int32.Parse(Console.ReadLine());
        _tempGoalList.Add(new SimpleGoal(newGoal, pointValue));
        Console.WriteLine("Item Recorded!");
    }
    public void EternalActivity(){
        Console.Clear();
        Console.WriteLine("Please enter your Eternal goal:");
        string newGoal = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("How many points is this activity worth?");
        int pointValue = Int32.Parse(Console.ReadLine());
        _tempGoalList.Add(new SpiritualGoal(newGoal, pointValue));
        Console.WriteLine("Item Recorded!");
    }
    public void ChecklistActivity(){
        Console.Clear();
        Console.WriteLine("Please enter your checklist item:");
        string newGoal = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("How many points for getting it done daily?");
        int pointValue = Int32.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("How many times to accomplish it?");
        int timesToFinish = Int32.Parse(Console.ReadLine());
        _tempGoalList.Add(new ChecklistGoal(newGoal, pointValue, timesToFinish, 0));
        Console.WriteLine("Item Recorded!");
    }
}