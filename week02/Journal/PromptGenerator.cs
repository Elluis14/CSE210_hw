using System;
using System.Collections.Generic;

public static class PromptGenerator
{
    private static List<string> _prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What is something you're grateful for today?",
        "Describe a moment that challenged you recently.",
        "How did you help someone today?",
        "What do you want to improve in yourself?"
    };

    public static string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}

