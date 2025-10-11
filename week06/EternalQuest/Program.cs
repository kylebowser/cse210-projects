// For this program I added a system to give the player a level
// the player will level up every 1000 points. 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}