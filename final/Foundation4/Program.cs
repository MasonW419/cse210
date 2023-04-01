using System;

class Program
{
    static void Main(string[] args)
    {
        RunningAct ra = new RunningAct("Running", "01 Apr 2023", 30, 3);
        CyclingAct ca = new CyclingAct("Cycling", "01 Apr 2023", 30, 7);
        SwimmingAct sa = new SwimmingAct("Swimming", "01 Apr 2023", 30, 100);
        Console.WriteLine(ra.GetSummary());
        Console.WriteLine(ca.GetSummary());
        Console.WriteLine(sa.GetSummary());
    }
}