using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who helped you recently?"
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "List positive things in your life."
        )
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();

        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("\nStart listing items...");
        ShowCountdown(3);

        int count = 0;

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        DisplayEndingMessage();
    }
}
