public class Swimming:Exercise{
    private int _lapCount;
    public Swimming(int lapCount, double timeInMinutes) : base(timeInMinutes){
        _lapCount=lapCount;
    }
    public override double GetDistance(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return (0.62*50*_lapCount/1000);
                //mi
            case 1:
                return (50*_lapCount/1000);
                //km
            default:
                return 0;
        }
    }
    public override double GetPace(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return base._timeInMinutes/(0.62*GetDistance(0));
                //mi
            case 1:
                return base._timeInMinutes/GetDistance(1);
                //km
            default:
                return 0;
        }
    }
    public override double GetSpeed(int mi_or_km)
    {
        switch(mi_or_km){
            case 0:
                return 0.62*GetDistance(0)/base._timeInMinutes*60;
                //mi
            case 1:
                return GetDistance(1)/base._timeInMinutes*60;
                //km
            default:
                return 0;
        }
    }
}