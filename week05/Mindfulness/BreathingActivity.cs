using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breath in... ");
            ShowCountDown(4);
            Console.Write("Now breath out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();

        Console.Clear();
    }
}