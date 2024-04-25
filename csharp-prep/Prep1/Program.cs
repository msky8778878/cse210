using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");


        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePer = int.Parse(userInput);

        string letter = "";
        if (gradePer >= 90)
        {
            letter = "A";
        }
        else if (gradePer >= 80)
        {
            letter = "B";
        }
        else if (gradePer >= 70)
        {
            letter = "C";
        }
        else if (gradePer >= 60)
        {
            letter = "D";
        }
        else if (gradePer < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Grade: {letter}");

        if (gradePer >= 70)
        {
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine("Maybe next time :(");
        }

        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        int guess = -1;

        while (guess != randomNumber)
        {
            Console.Write("Enter number: ");
            guess = int.Parse(Console.ReadLine());

            if (randomNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct!");
            }

        }

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number (0 = exit): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Sum: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Average: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"Maximum: {max}");

        DisplayWelcomeMessage();

        string userName = PromptUserName();

        userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");

        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter favorite number: ");

        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return (number * number);
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Squared number: {square}");
    }
}