using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        events.Add(new Lecture("Doctor Phil",450,"Anatomy of the Human Brain","Come as Doctor Phil teaches us about the Human brain.","7:00pm","I-Center",SetDate("08/18/2018 19:00:00")));
        events.Add(new Reception("noreply@byui.edu","Anna and Alex's Wedding!","Anna and Alex are getting married! Come celebrate with us!","8am","750 S 2nd St E, Rexburg, ID 83440", SetDate("08/18/2018 08:00:00")));
        events.Add(new Outdoors("Sunny","Movie in the Park","We will be watching Return of the Jedi this week!","8:00pm","Porter Park", SetDate("08/18/2018 20:00:00")));
        foreach (var item in events)
        {
            Console.WriteLine($"{item.GenerateDetails(0)}\n");
            Console.WriteLine($"{item.GenerateDetails(1)}\n");
            Console.WriteLine($"{item.GenerateDetails(2)}\n");
        }
        DateTime SetDate(string date){
            return DateTime.Parse(date);
        }
    }
    
}