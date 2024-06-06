class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int durationInMin, double speed) : base(date, durationInMin)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetDurationInMin() / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetShortDate()} - Cycling Activity({GetDurationInMin()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}