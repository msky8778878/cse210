using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture1 = new Lecture("Lecture about Birds", "You will learn all there is about birds!", "1/1/2024", "10:00AM", new Address("Best Street 45", "Nicetown", "YO", "Bestcountry"), "Raven Pigeony", 50);
        Reception reception1 = new Reception("Yet Another Reception", "This will be yet another reception in this town!", "2/2/2023", "5:30PM", new Address("Good Avenue 6", "Sunny City", "Paparapa", "Divided Kingdom"), "emailforreception@company.com");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Summer Games Gathering", "We will gather outside and play some games!", "3/3/2022", "12:15PM", new Address("Forest Road 10", "Springfield", "Old York", "Lalala"), "Sunny Weather All Day");

        List<Event> events = new List<Event>();
        events.Add(lecture1);
        events.Add(reception1);
        events.Add(outdoorGathering1);

        foreach (Event oneEvent in events)
        {
            Console.WriteLine();
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(oneEvent.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("FULL DETAILS:");
            Console.WriteLine(oneEvent.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("SHORT DESCRIPTION:");
            Console.WriteLine(oneEvent.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine("---------------------------");
        }
    }
}