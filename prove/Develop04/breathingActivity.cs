using System;

class BreathingActivity : Activity
{
    private string _breathIn = "Breathe In...";
    private string _breathOut = "Now Breathe Out...";
    public BreathingActivity(string name, string description)
        : base(name, description)
    {

    }
    public void RunActivity(int length)
    {
        bool done = false;
        SetEndTime(length);
        Console.Clear();
        Console.WriteLine("Get ready...");
        AnimateBar(14);
        Random r = new Random();
        while(!done)
        {
            Console.WriteLine();
            Breathe(r.Next(3, 7), r.Next(3, 7));
            done = FinishedActivity();
        }
        FinishingMessage(length);
    }
    public void Breathe(int inhale, int exhale)
    {
        Console.WriteLine(_breathIn);
        Countdown(inhale);
        Console.WriteLine(_breathOut);
        Countdown(exhale);
    }
}