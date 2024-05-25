using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}

/*
BONUS:
Level system
- added class Level.cs and implemented it to the GoalManager.cs
- takes the score from goals and passes it as XP (experience)
- if a certain amount of XP is reached, level is incremented, and XP required is consumed, excess is saved for the next level
- the higher the level, the more XP is need for the next level
*/