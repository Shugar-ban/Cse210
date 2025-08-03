using System;

class Program
{
    static void Main(string[] args)
    {
    var reference = new Reference("Proverbs", 3, 5, 6);
        string verseText = "Trust in the Lord with all thine heart and lean not unto thine own understanding";

        var scripture = new Scripture(reference, verseText);

        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine("Final hidden scripture:");
        Console.WriteLine(scripture.GetDisplayText());
    }
}