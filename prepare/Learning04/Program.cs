using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Kelvin Lemos","Multiplication");
        string test = a.GetSummary();
        Console.WriteLine(test);

        MathAssignment m = new MathAssignment("Kelvin Lemos","Multiplication","7.3","8-19");
        string test2 = m.GetSummary();
        string test3 = m.GetHomeworkList();
        Console.WriteLine($"{test2} \n{test3}");

        WritingAssignment w = new WritingAssignment("Kelvin Lemos","European History","The Causes of World War");
        string write = w.GetSummary();
        string write2 = w.GetWritingInfo();
        Console.WriteLine($"{write}\n{write2}");
    
    
    
    }   
}