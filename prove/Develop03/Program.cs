using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        // BONUS START
        /* 
        BONUS - Choose difficulty
        EASY (bonus) - first letter of each word is always visible
        HARD - same as the assignment
        */
        Console.WriteLine("Press enter difficulty ('easy'/'hard'): ");
        userInput = Console.ReadLine();
        bool easyDifficulty = true; // easy - true, hard - false
        if (userInput == "hard") easyDifficulty = false;

        Console.Clear();
        // BONUS END

        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(easyDifficulty, reference1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");


        while (userInput != "quit")
        {

            Console.WriteLine(scripture1.GetDisplayText());

            Console.WriteLine();

            Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");

            userInput = Console.ReadLine();

            Console.Clear();

            if (scripture1.IsCompletelyHidden()) userInput = "quit";

            scripture1.HideRandomWords(3);
        }


    }
}