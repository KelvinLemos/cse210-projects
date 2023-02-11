using System;

class Program
{
    static void Main(string[] args)
    {   
        
        Scripture scrip = new Scripture("Mosiah 5:2","And they all cried with one voice, saying: Yea, we believe all the words which thou hast spoken unto us; and also, we know of their surety and truth, because of the Spirit of the Lord Omnipotent, which has wrought a mighty change in us, or in our hearts, that we have no more disposition to do evil, but to do good continually.");
        scrip.Words = scrip.list();
        
        scrip.Display();
        Word w = new Word();
        
    
        string quit = Console.ReadLine();
        while (quit != "quit");
            {
                
            //w.get_random();
            //w._Word = scrip.list();


            }
        
        
        
        
        
        Console.ReadKey();
        
        
        

    }



}
//string quit = Console.ReadLine();
        //while (quit != "quit")
           //{ 
            //Console.WriteLine("Please type enter to continue or quit to finish: ");