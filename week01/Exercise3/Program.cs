using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.Write("Guess the number: ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);

        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Smaller");
            }
            else
            {
                Console.WriteLine("Greater");
            }

            Console.Write("What is your guess: ");
            guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
        }
        Console.WriteLine("You guessed it!");
    }
}