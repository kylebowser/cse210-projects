using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int _userSelect = -1;
        while (_userSelect != 5)
        {

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            _userSelect = int.Parse(userInput);

            if (_userSelect == 1)
            {
                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{entry._promptText}");
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (_userSelect == 2)
            {
                journal.DisplayAll();
            }
            else if (_userSelect == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);

            }
            else if (_userSelect == 4)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
        }
    }
}