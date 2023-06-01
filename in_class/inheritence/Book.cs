public class Book:Loanable{
    private string _isbn;
    private int _upc;

    public Book(string title, string isbn, string upc){
        base._title=title;
        _isbn=isbn;
        _upc=upc;
    }
    public void ShowBookDetails(){
        Console.WriteLine($"{_title} : {_isbn} :: {_upc} {_isCheckedIn}");
    }

    public override void Display(){
        base.Display();
        Console.WriteLine($"Title: {_title}");
    }
}