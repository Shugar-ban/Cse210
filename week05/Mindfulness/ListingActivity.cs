using System;
using System.Collections.Generic;

namespace ActivityApp
{
    public class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>
        {
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
}