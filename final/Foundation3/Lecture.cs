class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string DisplayFullDetails()
    {
        return $"{DisplayStandartDetails()},\nSpeaker: {_speaker},\nCapacity: {_capacity}";
    }

    public override string DisplayShortDescription()
    {
        return $"Event: Lecture,\nTitle: {DisplayTitle()},\nDate: {DisplayDate()}";
    }
}
