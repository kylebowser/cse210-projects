using System;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Thread.Sleep(3000);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>()
        {
            "|", "/", "-", "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < futureTime)
        {
            for (int x = 0; x < 4; x++)
            {
                string s = animation[x];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}