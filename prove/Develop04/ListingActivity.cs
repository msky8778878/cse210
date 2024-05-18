using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };


    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;

    }

    public void Run()
    {
        _startCounter++;

        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();

        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        _count = GetListFromUser().Count;
        if (_count > 1)
            Console.WriteLine($"You listed {_count} items!");
        else if (_count == 1)
            Console.WriteLine($"You listed 1 item!");
        else
            Console.WriteLine($"You listed no items :(");

        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, _prompts.Count);
        Console.Write(" --- ");
        Console.Write(_prompts[randomNumber - 1]);
        Console.WriteLine(" --- ");
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (input != "")
                responses.Add(input);
        }

        return responses;
    }


}