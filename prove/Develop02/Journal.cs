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
}