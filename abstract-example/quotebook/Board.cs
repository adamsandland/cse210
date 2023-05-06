public class Board{
    private List<Quote> _quotes = new List<Quote>();


    private void NicePrint(string item){
        Console.WriteLine("-------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("-------------------");
    }
    public void ShowQuotes(){
        foreach(Quote quote in  _quotes){
            NicePrint(quote.GetQuote());
        }
    }

    public void AddQuote(Quote newQuote){
        _quotes.Add(newQuote);
    }

    public void RandomQuote(){
        var rand = new Random();
        var randomNum = rand.Next(0,_quotes.Count);
        NicePrint(_quotes[randomNum].GetQuote());
    }

    public void GetQuotesByAuthor(string author){
        foreach(Quote quote in _quotes){
            if(quote.HasAuthor(author)){
                NicePrint(quote.GetQuote());
            }
        }
    }
}