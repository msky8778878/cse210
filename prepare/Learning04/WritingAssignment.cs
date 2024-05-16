using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string sn, string t, string tl) : base(sn, t)
    {
        _title = tl;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}