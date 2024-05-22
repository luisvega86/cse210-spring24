public abstract class Activity
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        Thread.Sleep(3000);
    }

    public virtual void ShowSpinner(int seconds)
    {
        int totalSpins = seconds * 2;
        char[] spinChars = { '/', '-', '\\', '|' };
        int currentSpin = 0;

        for (int i = 0; i < totalSpins; i++)
        {
            Console.Write("\r" + spinChars[currentSpin++]);
            if (currentSpin >= spinChars.Length)
                currentSpin = 0;

            Thread.Sleep(500);
        }
        Console.Write("\r" + new string(' ', Console.WindowWidth));
        Console.Write("\r");
    }

    public virtual void ShowCountDown(int seconds)
{
    Console.CursorVisible = false;
    int currentLine = Console.CursorTop;

    for (int i = seconds; i > 0; i--)
    {
        Console.SetCursorPosition(0, currentLine);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLine);
        Console.Write(i);
        Thread.Sleep(1000);
    }

    Console.SetCursorPosition(0, currentLine);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.CursorVisible = true;
}
}