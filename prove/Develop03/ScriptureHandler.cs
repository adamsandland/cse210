public class ScriptureHandler{
    private string _reference;
    private List<string> _ListOfWords = new List<string>();
    private List<string> _ReferenceList = new List<string>();
    private string _lastWord;
    private int _lastIndex;
    private TextReader scripture;
    public ScriptureHandler(string fileName=""){
        scripture = new TextReader(fileName);
        
        _reference = scripture.GetRef();
        _ListOfWords = scripture.GetScript().Split(" ").ToList();
        _ReferenceList = _ListOfWords;
    }

    public void HideWord(){
        Random rnd = new Random();
        _lastIndex = rnd.Next(0, _ListOfWords.Count());
        _lastWord = _ListOfWords[_lastIndex];
        if(_ListOfWords[_lastIndex]!="____"){
            _ListOfWords[_lastIndex] = "____";
        }else{
            HideWord();
        }
    }
    public void RevealLastWord(){
        _ListOfWords[_lastIndex] = _lastWord;
    }
    public string ReturnRef(){
        return scripture.GetRef();
    }
    public string ReturnScript(){
        string complete="";
        foreach(string word in _ListOfWords){
            complete = complete+" "+word;
        }
        return complete;
    }
    public bool wordsLeft(){
        return _ListOfWords.TrueForAll(x => x.Equals("____"));
    }
}