using System;

// My extra for this project is that I added a feature to the
// reflecting activity that makes it so that it will not repeat
// questions until it has used all the questions in the list and
// then it will reset the list.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string bName = "Breathing Activity";
        string bDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        string rName = "Reflection Activity";
        string rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        string lName = "Listing Activity";
        string lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        string input = "";

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            Console.Clear();

            if (input == "1")
            {
                BreathingActivity breath = new BreathingActivity(bName, bDescription);

                breath.Run();
            }
            else if (input == "2")
            {
                ReflectingActivity reflect = new ReflectingActivity(rName, rDescription);

                reflect.Run();
            }
            else if (input == "3")
            {
                ListingActivity list = new ListingActivity(lName, lDescription);

                list.Run();
            }
        } while (input != "4");
    }
}