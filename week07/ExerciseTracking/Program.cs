using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Swimming swimming = new Swimming(5, "03 Nov 2022", 30);
        Running running = new Running("03 Nov 2022", 4.8, 30);
        Biking biking = new Biking(10, "03 Nov 2022", 30);

        activities.Add(swimming);
        activities.Add(running);
        activities.Add(biking);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

}