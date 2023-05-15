public class Fraction{
    int _top;
    int _bottom;
    public Fraction(){
        _top=1;_bottom=1;
    }
    public Fraction(int numerator){
        _top=numerator;_bottom=1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom=bottom;
    }

    public int GetTop(){return _top;}
    public int GetBottom(){return _bottom;}
    public void SetTop(int value){_top=value;}
    public void SetBottom(int value){_bottom=value;}

    public string GetAsString(){return $"{_top}/{_bottom}";}
    public double GetAsDouble(){return (double)_top/_bottom;}
}