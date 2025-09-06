using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is a {letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats on passing!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}