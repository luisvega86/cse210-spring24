public class Program
{
    public static void Main()
    {
        var address1 = new Address("Hogwarts Castle", "Highlands", "Scotland", "Great Britain");
        var lecture = new Lecture("How to Brew Polyjuice Potion", "A detailed guide on brewing the most confusing potion in the wizarding world", new DateTime(2023, 6, 15), new DateTime(2023, 6, 15, 10, 0, 0), address1, "Professor Snape", 100);

        var address2 = new Address("Senate Building", "Coruscant", "Core Worlds", "Galaxy Far, Far Away");
        var reception = new Reception("Death Star Destruction Celebration", "Celebrate the destruction of the Death Star with heroes of the Rebel Alliance on Coruscant", new DateTime(2023, 7, 20), new DateTime(2023, 7, 20, 18, 0, 0), address2, "rsvp@rebellion.com");

        var address3 = new Address("1 Bagshot Row", "Hobbiton", "Shire", "Middle-earth");
        var outdoorGathering = new Outdoor("Bilbo Baggins' Birthday Party", "A grand celebration for Bilbo's eleventy-first birthday in the Shire", new DateTime(3001, 9, 22), new DateTime(3001, 9, 22, 19, 0, 0), address3, "Expect sunny skies and plenty of fireworks");


        var events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.DisplayStandartDetails());
            Console.WriteLine();
            Console.WriteLine(ev.DisplayFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.DisplayShortDescription());
            Console.WriteLine(new string('-', 40));
        }
    }
}