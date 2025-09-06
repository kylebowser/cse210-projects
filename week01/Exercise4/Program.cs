using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);

        if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;

        foreach (int part in numbers)
        {
            sum += part;
        }

        Console.WriteLine($"Sum is {sum}");

        float count = numbers.Count;
        float average = sum / count;

        Console.WriteLine($"Average is {average}");

        int largest = -1;

        foreach (int part in numbers)
        {
            if (part > largest)
            {
                largest = part;
            }
        }

        Console.WriteLine($"Largest is {largest}");
    }
}