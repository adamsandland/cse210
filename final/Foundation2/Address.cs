public class Address{
    private string _streetAd, _city, _state, _country;
    public Address(string streetAd, string city, string state, string country){
        _streetAd=streetAd;
        _city=city;
        _state=state;
        _country=country;
    }
    public bool LivesInUSA(){
        if(_country=="United States of America"){
            return true;
        }
        return false;
    }
    public string GetAddress(){
        return $"{_streetAd},\n{_city}, {_state} {_country}";
    }
}