using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment assingment1 = new MathAssignment("Roberto Rodriguez", "Fractions",
        "7.3", "8-19");

        WritingAssignment assignment2 = new WritingAssignment("Mary Waters",
        "European History", "The Causes of World War II");

        Console.WriteLine(assingment1.GetSummary());
        Console.WriteLine(assingment1.GetHomeworkList());

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}