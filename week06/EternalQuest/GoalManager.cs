using System;
using System.Runtime.CompilerServices;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;

    public GoalManager()
    {

    }

    public void Start()
    {
                string input = "";

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            Console.Clear();

            if (input == "1")
            {
                CreateGoal();
                Console.WriteLine();
            }
            else if (input == "2")
            {
                ListGoalDetails();
                Console.WriteLine();
            }
            else if (input == "3")
            {
                SaveGoals();
                Console.WriteLine();
            }
            else if (input == "4")
            {
                LoadGoals();
                Console.WriteLine();
            }
            else if (input == "5")
            {
                RecordEvent();
                Console.WriteLine();
            }
        } while (input != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        GetLevel();
        Console.WriteLine($"Player level {_level}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals are:");
        for (int y = 0; y < _goals.Count; y++)
        {
            string[] parts = _goals[y].GetStringRepresentation().Split("*");
            Console.WriteLine($"{y + 1}. {parts[2]}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        int x = 1;
        foreach (Goal goal in _goals) 
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"{x}. {goal.GetDetailsString()}");
                x++;
            }
            else
            {
                Console.WriteLine($"{x}. {goal.GetDetailsString()}");
                x++;
            }
        }
    }

    public void CreateGoal()
    {
        string input2 = "";
        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goals");
        Console.WriteLine("  3. Checklist Goals");
        Console.Write("What type of goal would you like to create? ");
        input2 = Console.ReadLine();

        if (input2 == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (input2 == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (input2 == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for the bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int input3 = int.Parse(Console.ReadLine());

        _score += _goals[input3 - 1].RecordEvent();
    }

    public void GetLevel()
    {
        int firstDigit = 0;
        if (_score < 1000)
        {
            firstDigit = 0;
        }
        else
        {
            firstDigit = _score / 1000;
        }
        _level = firstDigit;
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("*");

            if (parts[0] == "X")
            {
                if (parts[1] == "1")
                {
                    SimpleGoal sg = new SimpleGoal(parts[2], parts[3], parts[4]);

                    if (parts[5] == "false")
                    {
                        _goals.Add(sg);
                    }
                    else
                    {
                        sg.RecordEvent();
                        _goals.Add(sg);
                    }
                }
                else if (parts[1] == "2")
                {
                    EternalGoal sg = new EternalGoal(parts[2], parts[3], parts[4]);
                }
                else if (parts[1] == "3")
                {
                    ChecklistGoal sg = new ChecklistGoal(parts[2], parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]));
                }
            }
            
            else
            {
                _score = int.Parse(parts[0]);
            }
        }
    }
}