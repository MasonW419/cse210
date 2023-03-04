using System;

class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>();
    private List<string> _userInputs = new List<string>();
    public ListingActivity(string name, string description)
        : base(name, description)
    {
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heroes?");
    }
    public void RunActivity(int length)
    {
        bool done = false;
        Console.Clear();
        Console.WriteLine("Get ready...");
        AnimateBar(15);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine("You may being in: ");
        Countdown(5);
        SetEndTime(length);
        int inputCount = 0;
        while(!done)
        {
            Console.Write("> ");
            Console.ReadLine();
            inputCount++;
            done = FinishedActivity();
        }
        Console.WriteLine($"You listed {inputCount} items!");
        FinishingMessage(length);
    }
    public string GetRandomPrompt()
    {
        Random r = new Random();
        return _listingPrompts[r.Next(0, _listingPrompts.Count - 1)];
    }
}