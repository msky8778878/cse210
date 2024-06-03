using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swimming1 = new Swimming("1/2/2001", 25, 12);
        Running running1 = new Running("2/3/2002", 110, 10.5F);
        Cycling cycling1 = new Cycling("3/4/2003", 180, 15.8F);

        List<Activity> activities = new List<Activity>();
        activities.Add(swimming1);
        activities.Add(running1);
        activities.Add(cycling1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}