public class Menu{
    private Journal currentJournal;
    public void Display(){
        string selection ="";
        Console.Clear();
        Console.WriteLine("To begin, please enter the path to your journal file:");
        string journalPath = Console.ReadLine();
        currentJournal = new Journal(journalPath);
        while(selection!=("C") || selection!=("V") || selection!=("E")){
            Console.WriteLine("Welcome to your journal!\n\nPlease select one of the following:\n[C]reate a new entry\n[V]iew Entries\n[E]xit and save\n");
            selection = Console.ReadLine().ToUpper();

            if(selection == "C"){
                Console.Clear();
                Console.WriteLine($"{currentJournal.TodaysPrompt("random")}");
                Console.WriteLine("Please begin writing your entry below. When you are satisfied with an entry, press [Enter] to submit.\n");
                string entry = Console.ReadLine();
                Entry newEntry = new Entry(DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), entry);
                currentJournal.NewEntry(newEntry);
                selection="";
                Console.Clear();
            }else if(selection =="V"){
                Console.Clear();
                currentJournal.ViewEntries();
            }else if(selection =="E"){
                Console.Clear();
                currentJournal.WriteEntries();
                break;
            }
        }
    }
}