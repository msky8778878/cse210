using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string sn, string t, string ts, string p) : base(sn, t)
    {
        _textbookSection = ts;
        _problems = p;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}