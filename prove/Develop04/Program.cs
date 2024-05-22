class Program
{
    static void Main(string[] args)
    {
        int choice;
        Console.WriteLine("Welcome to the Mindfulness App!");

        do
        {
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Guided Meditation Activity");
            Console.WriteLine("5. Quit");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case 3:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 4:
                    GuidedMeditationActivity guidedMeditationActivity = new GuidedMeditationActivity();
                    guidedMeditationActivity.Run();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } while (choice != 5);
    }
}
