using System;
using System.Collections.Generic;

class Video
{
    public string Title, Author;
    public int Length;
    public List<Comment> Comments = new();

    public Video(string title, string author, int length)
    {
        Title = title; Author = author; Length = length;
    }

    public void Add(string name, string text) => Comments.Add(new Comment(name, text));
}

class Comment
{
    public string Name, Text;
    public Comment(string name, string text) { Name = name; Text = text; }
}

class Program
{
    static void Main()
    {
        var vids = new List<Video>
        {
            new Video("C# Basics", "Jane", 300),
            new Video("Interfaces", "Mark", 450),
            new Video("LINQ Tips", "Sara", 600)
        };

        vids[0].Add("Amy", "Great intro!"); vids[0].Add("Ben", "Helpful."); vids[0].Add("Cara", "Clear and concise.");
        vids[1].Add("Dan", "Neat examples!"); vids[1].Add("Eve", "Thanks!"); vids[1].Add("Frank", "Well done.");
        vids[2].Add("Gina", "Made it simple."); vids[2].Add("Hank", "Awesome tips."); vids[2].Add("Ivy", "Nice video!");

        foreach (var v in vids)
        {
            Console.WriteLine($"{v.Title} by {v.Author}, {v.Length}s, Comments: {v.Comments.Count}");
            v.Comments.ForEach(c => Console.WriteLine($"- {c.Name}: {c.Text}"));
            Console.WriteLine();
        }
    }
}

