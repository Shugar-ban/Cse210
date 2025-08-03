using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string input = "";

        Console.WriteLine("📝 Welcome to your Daily Journal!");
        while (input != "5")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            input = Console.ReadLine()?.Trim();

            switch (input)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    Console.WriteLine("👋 Goodbye! Keep journaling.");
                    break;
                default:
                    Console.WriteLine("❌ Invalid option. Please choose 1–5.");
                    break;
            }
        }
    }
}