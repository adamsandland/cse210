public class Bicycles:Exercise{
    private int _speed;
    public Bicycles(int speed, double timeInMinutes) : base(timeInMinutes){
        _speed=speed;
    }
    public override double GetDistance(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return base._timeInMinutes/GetSpeed(0);
                //mi
            case 1:
                return base._timeInMinutes/GetSpeed(1);
                //km
            default:
                return 0;
        }
    }
    public override double GetPace(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return 60/GetSpeed(0);
                //mi
            case 1:
                return 60/GetSpeed(1);
                //km
            default:
                return 0;
        }
    }
    public override double GetSpeed(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return 0.62*_speed;
                //mi
            case 1:
                return _speed;
                //km
            default:
                return 0;
        }
    }
}