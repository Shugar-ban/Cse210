using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your first name?");
        Console.WriteLine("What is your last name?");

        string f_name = Console.ReadLine();
        string l_name = Console.ReadLine();

        Console.WriteLine($"Your name is {l_name},{f_name} {l_name}");
    }
}