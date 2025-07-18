
public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, int lengthMinutes, double speedKph)
        : base(date, lengthMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetDistance()
    {
        return (_speedKph * GetLengthMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speedKph;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLengthMinutes()} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}