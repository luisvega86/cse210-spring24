class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string title, string description, DateTime date, DateTime time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string DisplayFullDetails()
    {
        return $"{DisplayStandartDetails()},\nWeather Forecast: {_weatherForecast}";
    }

    public override string DisplayShortDescription()
    {
        return $"Event: Outdoor Gathering,\nTitle: {DisplayTitle()},\nDate: {DisplayDate()}";
    }
}