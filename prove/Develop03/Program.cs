using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture("1 Timothy", "4", "3", "Forbidding to marry, and commanding to abstain from meats, which God hath created to be received with thanksgiving of them which believe and know the truth.");
        bool prog = true;
        string verse = s.DisplayRenderedText();
        Console.WriteLine(verse);
        Console.WriteLine();
        Console.Write("Press Enter to continue or type 'quit' to finish: ");
        string userInput = Console.ReadLine();
        if(userInput == "quit") 
        {
            prog = false;
        }
        while (prog)
        {   
            Console.Clear();
            s.HideWords(3);
            verse = s.DisplayRenderedText();
            Console.WriteLine(verse);
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            if(s.IsAllHidden() || userInput == "quit")
            {
                prog = false;
            }
        }
    }
}