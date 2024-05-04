public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void WriteEntry(PromptGenerator promptGenerator)
    {
        Prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine("Enter your response: ");
        Response = Console.ReadLine();
        Date = DateTime.Now.ToShortDateString();

    }
}