using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Journal journal = new Journal();

        while (option != 5)
        {
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display journal content");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Search entry by date");
            Console.WriteLine("What do you want to do? ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("1. Write an entry");

                    Entry newEntry = new Entry();

                    PromptGenerator promptGenerator = new PromptGenerator();
                    newEntry._promptText = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"{newEntry._promptText}");
                    newEntry._entryText = Console.ReadLine();

                    DateTime theCurrentTime = DateTime.Now;
                    newEntry._date = theCurrentTime.ToShortDateString();

                    journal.AddEntry(newEntry);

                    Console.WriteLine("Entry saved");

                    break;
                case 2:
                    Console.WriteLine("2. Display journal content");

                    journal.DisplayAll();

                    break;
                case 3:
                    Console.WriteLine("3. Save to a file");

                    Console.Write("Enter path/filename: ");
                    string filenamesave = Console.ReadLine();

                    journal.SaveToFile(filenamesave);

                    Console.WriteLine($"Journal saved to '{filenamesave}'");

                    break;
                case 4:
                    Console.WriteLine("4. Load from a file");

                    Console.Write("Enter path/filename: ");
                    string filenameread = Console.ReadLine();

                    journal.LoadFromFile(filenameread);

                    Console.WriteLine($"Journal loaded from '{filenameread}'");

                    break;
                case 5:
                    Console.WriteLine("5. Exit");
                    break;
                case 6:
                    Console.WriteLine("6. Search entry by date");

                    DateTime theCurrentTime2 = DateTime.Now;
                    string theCurrentTime2str = theCurrentTime2.ToShortDateString();

                    Console.Write($"Enter date like this '{theCurrentTime2str}': ");
                    string inputdate = Console.ReadLine();

                    journal.DisplayByDate(inputdate);

                    break;
                default:
                    Console.WriteLine("Error: invalid option - enter again");
                    break;
            }
        }
    }
}