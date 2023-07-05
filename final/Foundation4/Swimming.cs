public class Swimming:Exercise{
    private int lapCount;
    public override string GetDistance(int mi_or_km)
    {
        return base.GetDistance(mi_or_km);
    }
    public override string GetPace(int mi_or_km)
    {
        return base.GetPace(mi_or_km);
    }
    public override string GetSpeed(int mi_or_km)
    {
        return base.GetSpeed(mi_or_km);
    }
}