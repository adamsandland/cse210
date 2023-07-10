public class Running:Exercise{
    private int _distance;

    public Running(int distance, double timeInMinutes) : base(timeInMinutes){
        _distance=distance;
    }
    public override double GetDistance(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return _distance*0.62;
                //mi
            case 1:
                return _distance;
                //km
            default:
                return 0;
        }
    }
    public override double GetPace(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return base._timeInMinutes/(0.62*_distance);
                //mi
            case 1:
                return base._timeInMinutes/_distance;
                //km
            default:
                return 0;
        }
    }
    public override double GetSpeed(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return 0.62*_distance/base._timeInMinutes*60;
                //mi
            case 1:
                return _distance/base._timeInMinutes*60;
                //km
            default:
                return 0;
        }
    }
}