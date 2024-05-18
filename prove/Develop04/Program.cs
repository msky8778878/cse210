using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        while (option != 4)
        {
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Exit");

            option = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (option)
            {
                case 1:
                    breathingActivity.Run();
                    break;
                case 2:
                    reflectingActivity.Run();
                    break;
                case 3:
                    listingActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("4. Exit");
                    break;

                default:
                    Console.WriteLine("Error: invalid option - enter again");
                    break;
            }
        }

        // bonus
        Console.WriteLine("Statistics:");
        Console.WriteLine($"You performed the {breathingActivity.GetName()} {breathingActivity.GetStartCounter()} times!");
        Console.WriteLine($"You performed the {reflectingActivity.GetName()} {reflectingActivity.GetStartCounter()} times!");
        Console.WriteLine($"You performed the {listingActivity.GetName()} {listingActivity.GetStartCounter()} times!");
    }
}