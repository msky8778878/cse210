using System;

public class Level
{
    private int _level; // current level
    private int _levelScale; // amount of extra XP needed for each passing level
    private int _currentXP; // current XP
    private int _fullXP; // XP required for the next level

    public Level(int baseXP, int levelScale)
    {
        _level = 1;
        _levelScale = levelScale;
        _currentXP = 0;
        _fullXP = baseXP;
    }

    public int GetLevel()
    {
        return _level;
    }

    public int GetCurrentXP()
    {
        return _currentXP;
    }

    public int GetFullXP()
    {
        return _fullXP;
    }

    public void AddXP(int amount)
    {
        _currentXP += amount;
        while (_currentXP >= _fullXP)
        {
            _currentXP = _currentXP - _fullXP;
            _fullXP += _levelScale;
            _level++;

            Celebration();
        }
    }

    private void Celebration()
    {
        Console.WriteLine("New level! Congratulations!!!!");
        Console.WriteLine($"{_level - 1} -> {_level}");
    }
}