public class GuidedMeditationActivity : Activity
{
    private List<string> meditationSteps = new List<string>
    {
        "Close your eyes and take a deep breath...",
        "Feel your breath going in and out...",
        "Relax your muscles, starting from your feet and moving up to your head...",
        "Listen to the sounds around you without judgment...",
        "Observe the thoughts passing through your mind and let them go...",
        "Visualize a place that makes you feel peaceful and safe..."
    };

    public GuidedMeditationActivity() : base("Guided Meditation Activity", "This activity will help you relax and center yourself through a guided meditation session.", 30)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Get ready to begin guided meditation...");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            foreach (var step in meditationSteps)
            {
                if (DateTime.Now >= futureTime) break;
                Console.WriteLine(step);
                ShowSpinner(10);
            }
        }

        DisplayEndingMessage();
    }
}
