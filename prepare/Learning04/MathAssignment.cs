using System;
 

class MathAssignment : Assignment

{
    private string _textbookSection;
    private string _problems;

    //Constructors
    public MathAssignment() : base() {}

    public MathAssignment(string name, string topic, string textbook, string problems) : base(name, topic)
    {
       this._textbookSection = textbook;
       this._problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}