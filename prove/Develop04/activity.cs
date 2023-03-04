using System;

class Activity
{
    private string _name;
    private string _startDescription;
    private string _endDescription;
    private DateTime _startTime;
    private DateTime _endTime;
    private char[] animations = {'-','/','|','/'};
    private int selector = 0;
    public Activity(string name, string start)
    {
        _name = name;
        _startDescription = start;
    }
    public void SetEndTime(int length)
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(length + 3);
    }
    public bool FinishedActivity()
    {
        DateTime currentTime = DateTime.Now;
        bool finished = false;
        if(currentTime > _endTime)
        {
            finished = true;
        }
        return finished;
    }
    public void AnimateBar(int timer)
    {
        char[] animations = {'-','/','|','\\'};
        int selector = 0;
        while(timer > 0)
        {
            Console.Write(animations[selector]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            selector++;
            if(selector > 3)
            {
                selector = 0;
            }
            timer--;
        }
    }
    public void Countdown(int timer)
    {
        while(timer > 0)
        {
            Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            timer--;
        }
    }
    public void WelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_startDescription);
        Console.WriteLine();
    }
    public void FinishingMessage(int length)
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        AnimateBar(16);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {length} seconds of the {_name}.");
        AnimateBar(16);
        Console.Clear();
    }
}