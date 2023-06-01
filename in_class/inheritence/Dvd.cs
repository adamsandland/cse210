public class Dvd:Loanable{

    public Dvd(string title){
        base._title=title;
    }

    public override void Display(){
        base.Display();
        Console.WriteLine($"Title: {_title}");
    }
}