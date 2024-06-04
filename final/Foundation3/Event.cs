class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string DisplayStandartDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToShortTimeString()}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string DisplayShortDescription()
    {
        return $"Title: {_title},\nDate: {_date}";
    }

    public virtual string DisplayFullDetails()
    {
        return DisplayStandartDetails();
    }

    public string DisplayTitle()
    {
        return _title;
    }

    public string DisplayDate()
    {
        return _date.ToShortDateString();
    }
}