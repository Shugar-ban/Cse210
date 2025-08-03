using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    private int duration;

    protected string Name { get; set; }
    protected string Description { get; set; }

    public void Start()
    {
        Console.WriteLine($"\nWelcome to the {Name} Activity");
        Console.WriteLine($"{Description}");
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        PauseWithDots(3);

        ExecuteActivity();

        Console.WriteLine($"\nWell done! You completed the {Name} activity for {duration} seconds.");
        Console.WriteLine("Take a moment to reflect...");
        PauseWithDots(5);
    }

    protected int GetDuration() => duration;

    protected void PauseWithDots(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void ExecuteActivity();
}

class ListingActivity : Activity
{
    private List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void ExecuteActivity()
    {
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("Get ready...");
        PauseWithCountdown(5);

        Console.WriteLine("\nStart listing! (Press Enter after each item)");

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                itemCount++;
        }

        Console.WriteLine($"\nYou listed {itemCount} items. Awesome!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1 - Listing");

        string choice = Console.ReadLine();

        Activity activity = choice switch
        {
            "1" => new ListingActivity(),
            _ => null
        };

        if (activity != null)
            activity.Start();
        else
            Console.WriteLine("Invalid selection.");
    }
}