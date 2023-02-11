using System;
class Word 
{
    private int _localize;
    private List<string> _word = new List<string>();
    private List<string> _otherlist = new List<string>();
    private string _hidden;

    //public List<string> word { get => _word; set => _word = value; }
    
    public List<string> _Word { get => _word; set => _word = value; }
    
    public void get_random(){
        //var r = new Random(); 
        //int index = r.Next(_Word.Count);
        Random random = new Random();
        _localize = random.Next(_Word.Count);
        _hidden = _word[_localize];


        //Console.WriteLine ( _word.Count() );

    }
    
}