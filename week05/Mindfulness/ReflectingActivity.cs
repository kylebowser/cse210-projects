using System;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<bool> _usedQuestions = new List<bool>()
    {
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false,
        false
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.Write("When you have something in mind you many press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experiance.");
        Console.Write("You may begin in ...");
        ShowCountDown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.Write(GetRandomQuestion());
            ShowSpinner(10);

        }

        
        Console.WriteLine();

        DisplayEndingMessage();

        Console.Clear();
    }

    private string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, 4);
        return _prompts[num];
    }

    private string GetRandomQuestion()
    {
        bool end = false;

        while (end == false)
        {
            Random randomGenerator = new Random();
            int num = randomGenerator.Next(0, 9);

            if (_usedQuestions[num] == false)
            {
                _usedQuestions[num] = true;
                return _questions[num];
            }

            int usedCount = 0;
            for (int x = 0; x < _usedQuestions.Count; x++)
            {
                if (_usedQuestions[x])
                {
                    usedCount += 1;
                }
            }
            if (usedCount == _usedQuestions.Count)
            {
                end = true;
            }
        }

        for (int i = 0; i < _usedQuestions.Count; i++)
        {
            _usedQuestions[i] = false;
        }

        return GetRandomQuestion();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}