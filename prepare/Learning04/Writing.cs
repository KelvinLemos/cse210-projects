using System;


class WritingAssignment : Assignment
{
    private string _title;

    // Constructors
    public WritingAssignment() : base(){}
    public WritingAssignment(string name,string topic,string title) : base(name,topic)
    {
        this._title = title;
    }
    // Methods

    
    public string GetWritingInfo()
    {
        string student = GetStudentName();
        return $"{_title} by {student} ";
    }

}