using System;
using Microsoft.VisualBasic;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in...");
        ShowCountDown(5);
        List<string> list = GetListFromUser();

        Console.WriteLine($"Congrats you listed {list.Count()} items!");
        Console.WriteLine();

        DisplayEndingMessage();

        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, 5);
        Console.WriteLine($"--- {_prompts[num]} ---");
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);


        List<string> inputs = new List<string>();

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            inputs.Add(input);
            currentTime = DateTime.Now;
        }

        return inputs;
    }
}