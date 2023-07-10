public abstract class Exercise{
    private DateTime _date;
    protected double _timeInMinutes;
    public Exercise(double timeInMinutes){
        _timeInMinutes=timeInMinutes;
    }
    public abstract double GetDistance(int mi_or_km);
    public abstract double GetSpeed(int mi_or_km);
    public abstract double GetPace(int mi_or_km);
    public string GetSummary(){
        return $"Summary:\nDistance: {Math.Round(GetDistance(0), 2)}mi\nPace: {Math.Round(GetPace(0),2)}min/mi\nSpeed: {Math.Round(GetSpeed(0),2)}mph";
    }
}