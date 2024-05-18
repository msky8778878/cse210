using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

    public ReflectingActivity() : base()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            Console.WriteLine();
            ShowSpinner(15);
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, _prompts.Count);

        return _prompts[randomNumber - 1];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, _questions.Count);

        return _questions[randomNumber - 1];
    }

    private void DisplayPrompt()
    {
        Console.Write(" --- ");
        Console.Write(GetRandomPrompt());
        Console.WriteLine(" --- ");
    }

    private void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
        Console.Write(" ");
    }

}