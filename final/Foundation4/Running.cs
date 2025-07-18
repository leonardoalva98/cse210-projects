public class Running : Activity
{
    private double _distanceKm;

    public Running(string date, int lengthMinutes, double distanceKm)
        : base(date, lengthMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        return (_distanceKm / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / _distanceKm;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLengthMinutes()} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}