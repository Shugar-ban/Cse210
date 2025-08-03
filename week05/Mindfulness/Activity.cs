using System;
using System.Threading;

namespace ActivityApp
{
    public abstract class Activity
    {
        private int duration;

        protected string Name { get; set; }
        protected string Description { get; set; }

        public void Start()
        {
            Console.WriteLine($"\nWelcome to the {Name} Activity");
            Console.WriteLine($"{Description}");
            Console.Write("Enter duration in seconds: ");

            if (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                return;
            }

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
}