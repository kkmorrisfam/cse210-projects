using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }

    //constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
}