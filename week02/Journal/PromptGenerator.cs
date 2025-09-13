using System;


class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "Did I do any good today?",
        "Did I have any regrets today?",
        "Did I feel the spirit today?"
    };
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, 5);
        return _prompts[num];
    }
}