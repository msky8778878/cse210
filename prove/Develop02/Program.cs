using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        //todo - deklarace objektu

        while (option != 5)
        {
            Console.Write("1. Write an entry");
            Console.Write("2. Display journal content");
            Console.Write("3. Save to a file");
            Console.Write("4. Load from a file");
            Console.Write("5. Exit");
            Console.Write("What do you want to do? ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("1. Write an entry");
                    //todo
                    break;
                case 2:
                    Console.Write("2. Display journal content");
                    //todo
                    break;
                case 3:
                    Console.Write("3. Save to a file");
                    //todo
                    break;
                case 4:
                    Console.Write("4. Load from a file");
                    //todo
                    break;
                case 5:
                    Console.Write("5. Exit");
                    break;
                default:
                    Console.Write("Error: invalid option - enter again");
                    break;
            }
        }
    }
}