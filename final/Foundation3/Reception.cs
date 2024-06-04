class Reception : Event
{
    private string _emailRSVP;

    public Reception(string title, string description, DateTime date, DateTime time, Address address, string emailRSVP) : base(title, description, date, time, address)
    {
        _emailRSVP = emailRSVP;
    }

        public override string DisplayFullDetails()
    {
        return $"{DisplayStandartDetails()},\nRSVP email: {_emailRSVP}";
    }

    public override string DisplayShortDescription()
    {
        return $"Event: Reception,\nTitle: {DisplayTitle()},\nDate: {DisplayDate()}";
    }
}