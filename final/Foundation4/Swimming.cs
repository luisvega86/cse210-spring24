class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int durationInMin, int numberOfLaps) : base(date, durationInMin)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDurationInMin() * 60;
    }

    public override double GetPace()
    {
        return GetDurationInMin() / GetDistance();
    }

    public int GetNumberOfLaps()
    {
        return _numberOfLaps;
    }

    public override string GetSummary()
    {
        return $"{GetShortDate()} - Swimming Activity({GetDurationInMin()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}