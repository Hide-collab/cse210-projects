using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you showed courage."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made this possible?"
    };

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "Reflect on times when you showed strength."
        )
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();

        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
