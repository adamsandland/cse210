public class Menu{
    private Board _board;

    public Menu(Board board){
        _board = board;
    }

    public void Display(){
        string response = "";
        string[] options = {"A","S","F","Q","R"};
        while(response!="Q"){
            while(options.Contains(response)==false){
                Console.Write("[A]dd quote\n[S]how quotes\n[F]ind quotes by author\n[R]andom quote\n[Q]uit\n\nWhat would you like to do?");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch(response){
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Console.WriteLine("Please enter your quote: ");
                    string quote = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Please enter your author: ");
                    string author = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Please enter your source: ");
                    string source = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Please enter your source url: ");
                    string sourceUrl = Console.ReadLine() ?? String.Empty;

                    _board.AddQuote(new Quote(author, quote, new Source(source, sourceUrl)));
                    break;
                case "S":
                    _board.ShowQuotes();
                    break;
                case "F":
                    Console.WriteLine("Please enter your author: ");
                    author = Console.ReadLine() ?? String.Empty;
                    _board.GetQuotesByAuthor(author);
                    break;
                case "R":
                    _board.RandomQuote();
                    break;

            }
            response = "";
        }
    }
}