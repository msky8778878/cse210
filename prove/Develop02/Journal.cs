using System;
using System.Collections.Generic;

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
        //todo
    }

    public void LoadFromFile(string filename)
    {
        //todo
    }
}