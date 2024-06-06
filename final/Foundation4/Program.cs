public class Program
{
    public static void Main()
    {
        // Create sample activities
        Swimming swimming = new Swimming(new DateTime(2024, 5, 13), 60, 20);
        Running running = new Running(new DateTime(2024, 5, 30), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2024, 6, 3), 45, 15.0);

        // List of activities
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}