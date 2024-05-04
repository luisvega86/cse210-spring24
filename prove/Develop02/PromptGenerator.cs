using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most challenging task I faced today?",
        "Did I learn something new today? If so, what was it?",
        "How did I show kindness or help someone today?",
        "What is one thing I'm grateful for today?",
        "What accomplishment am I proud of from today?",
        "Did I take any steps towards achieving my goals today?",
        "How did I take care of myself physically, mentally, or emotionally today?",
        "What mistake or failure did I learn from today?",
        "What made me laugh or brought me joy today?",
        "What is one thing I can improve or do differently tomorrow based on today's experiences?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}