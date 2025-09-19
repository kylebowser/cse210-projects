using System;

// For my stretch requirment I added a function that the program will only
// hide a word that isn't already hidden. This makes the program flow smoother
// since the user will always get a consistent amount of words being hidden.

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "I, Nephi, having been born of goodly parents, therefore I " +
        "was taught somewhat in all the learning of my father; and " +
        "having seen many afflictions in the course of my days," +
        "nevertheless, having been highly favored of the Lord in all my" +
        "days; yea, having had a great knowledge of the goodness and" +
        "the mysteries of God, therefore I make a record of my" +
        "proceedings in my days.";
        
        Reference reference = new Reference("1 Nephi", 1, 1);
        Scripture scripture = new Scripture(reference, scriptureText);

        string userChoice = null;
        bool isDone = false;

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userChoice = Console.ReadLine();
            isDone = scripture.IsCompletelyHidden();
            if (isDone)
            {
                break;
            }
            scripture.HideRandomWords(4);
        } while (userChoice != "quit");
    }
}