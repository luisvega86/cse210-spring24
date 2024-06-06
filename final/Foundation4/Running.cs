class Running : Activity
{
    private double _distanceInKm;

    public Running(DateTime date, int durationInMin, double distanceInKm) : base(date, durationInMin)
    {
        _distanceInKm = distanceInKm;
    }

    public override double GetDistance()
    {
        return _distanceInKm;
    }

    public override double GetSpeed()
    {
        return _distanceInKm / GetDurationInMin() * 60;
    }

    public override double GetPace()
    {
        return GetDurationInMin() / _distanceInKm;
    }

    public override string GetSummary()
    {
        return $"{GetShortDate()} - Running Activity({GetDurationInMin()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}