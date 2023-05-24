public class Player
{
    private string _name;
    private string _characterMain;
    private float _percentDamage;
    private float _kills;
    private float _deaths;
    private List<string> _charactersPlayed = new List<string>();

    public Player(string name, string characterMain){
        _name = name;
        _characterMain = characterMain;
    }
    public void UpdateAverageScores(int percentDamage, int kills, int deaths){
        if(_percentDamage!=0){_percentDamage=(float)(_percentDamage+percentDamage)/2;}else{_percentDamage=percentDamage;}
        if(_kills!=0){_kills=(float)(_kills+kills)/2;}else{_kills=kills;}
        if(_deaths!=0){_deaths=(float)(_deaths+deaths)/2;}else{_deaths=deaths;}
    }
    public void characterPlayed(string character){
        if(!_charactersPlayed.Contains(character)){_charactersPlayed.Add(character);}
    }
    public List<string> GetCharactersPlayed(){return _charactersPlayed;}
    public string StringifyData(){return $"{_name}\nAverage Damage: {_percentDamage}\nAverage Kills: {_kills}\nAverage Deaths: {_deaths}\n";}
}