using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private Level _level;

    public GoalManager()
    {
        _score = 0;
        _level = new Level(300, 25);
    }

    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Read Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Create New Goal");
                    CreateGoal();
                    break;
                case 2:
                    Console.WriteLine("2. List Goals");
                    ListGoalDetails();
                    break;
                case 3:
                    Console.WriteLine("3. Save Goals");
                    SaveGoals();
                    break;
                case 4:
                    Console.WriteLine("4. Read Goals");
                    LoadGoals();
                    break;
                case 5:
                    Console.WriteLine("5. Record Event");
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("6. Exit");
                    return;
                default:
                    Console.WriteLine("Error - invalid option! Please try again.");
                    break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Current level: {_level.GetLevel()}");
        Console.WriteLine($"Current xp (=points this level): {_level.GetCurrentXP()}");
        Console.WriteLine($"Next level at: {_level.GetFullXP()} xp");
    }

    private void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }

    private void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which goal did you accomplish? ");
        int select = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());


        switch (select)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                return;

            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                return;

            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                return;

            default:
                Console.WriteLine("Error - invalid option!");
                return;
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0) return;

        Console.WriteLine("The goals are:");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int select = int.Parse(Console.ReadLine());
        select--;
        if ((select >= _goals.Count) || (select < 0))
        {
            Console.WriteLine("Error - invalid option!");
            return;
        }

        int newPoints = _goals[select].RecordEvent();
        _score += newPoints;

        Console.WriteLine($"Congratulations! You have earned {newPoints} points!");
        Console.WriteLine($"You now have {_score} points.");
        _level.AddXP(newPoints);
        Console.WriteLine();
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string type = parts[0];

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3], parts[4]));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                    break;

                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], parts[5], parts[4], parts[6]));
                    break;
            }
        }
    }


}