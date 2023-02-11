using System;

class Scripture
{

    private List<string> _words = new List<string>();
    //private List<string> _scripture;
    private string _text;
    private string _reference;
    
    public Scripture(){}

    public Scripture(string Refer, string Text){
        _reference = Refer;
        _text = Text;
    }
    public Scripture(string Text){
        _text = Text;
        _reference = "Unknown";
    }
    
    
    

    
    public string Text { get => _text; set => _text = value; }
    public string reference { get => _reference; set => _reference = value; }
    public List<string> Words { get => _words; set => _words = value;} 
    
    public List<string> list(){
        return new List<string>(_text.Split(' '));
    }
    public void Display()
    {
        Console.Write("\n" + _reference + " ");
        foreach (var o in _words )
        Console.Write(o + " ");
        
    }

    public void Hide() {
        
        Console.WriteLine();
    }
    
}