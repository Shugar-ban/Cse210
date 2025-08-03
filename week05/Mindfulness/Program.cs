using System;

namespace ActivityApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1 - Listing");

            string choice = Console.ReadLine()?.Trim();
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
}