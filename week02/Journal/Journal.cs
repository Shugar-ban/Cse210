using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private Random rng = new Random();

    public void WriteEntry()
    {
        string prompt = prompts[rng.Next(prompts.Count)];
        Console.WriteLine($"\n📌 Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
        Console.WriteLine("✅ Entry added.\n");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\n📖 Your Journal Entries:\n");
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToFileFormat());
                }
            }
            Console.WriteLine("💾 Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️ Error saving file: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("📂 File not found.");
                return;
            }

            entries.Clear();
            foreach (var line in File.ReadAllLines(filename))
            {
                entries.Add(Entry.FromFileFormat(line));
            }
            Console.WriteLine("✅ Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️ Error loading file: {ex.Message}");
        }
    }
}