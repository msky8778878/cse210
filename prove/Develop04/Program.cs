using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;

        BreathingActivity ba1 = new BreathingActivity();
        ReflectingActivity ra1 = new ReflectingActivity();
        ListingActivity la1 = new ListingActivity();

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
                    ba1.Run();
                    break;
                case 2:
                    ra1.Run();
                    break;
                case 3:
                    la1.Run();
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
        Console.WriteLine($"You performed the {ba1.GetName()} {ba1.GetStartCounter()} times!");
        Console.WriteLine($"You performed the {ra1.GetName()} {ra1.GetStartCounter()} times!");
        Console.WriteLine($"You performed the {la1.GetName()} {la1.GetStartCounter()} times!");
    }
}