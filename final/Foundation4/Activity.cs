class Activity
{
    private DateTime _date;
    private int _durationInMin;

    public Activity(DateTime date, int durationInMin)
    {
        _date = date;
        _durationInMin = durationInMin;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString} - Activity duration: {_durationInMin}\nDistance: {GetDistance()}\nSpeed: {GetSpeed()}\nPace: {GetPace()}";
    }

    public int GetDurationInMin()
    {
        return _durationInMin;
    }

    public string GetShortDate()
    {
        return _date.ToShortDateString();
    }
}