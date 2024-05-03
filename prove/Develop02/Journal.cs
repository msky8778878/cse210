using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry oneEntry in _entries)
        {
            oneEntry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry oneEntry in _entries)
            {
                outputFile.WriteLine($"{oneEntry._date}|{oneEntry._promptText}|{oneEntry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry oneEntry = new Entry();

            string[] parts = line.Split("|");

            oneEntry._date = parts[0];
            oneEntry._promptText = parts[1];
            oneEntry._entryText = parts[2];

            _entries.Add(oneEntry);
        }
    }

    //BONUS:
    /*
    This bonus function will get a date (from user in the main function), search the list and find and display all entries with the same date
    I am comparing 2 strings here which I know is not good but at least in the prompt to insert date the user gets the right format in which is he supposed to write it
    */
    public void DisplayByDate(string date)
    {
        foreach (Entry oneEntry in _entries)
        {
            if (String.Equals(oneEntry._date, date))
            {
                oneEntry.Display();
            }
        }
    }
}