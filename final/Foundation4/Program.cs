using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningAct("Running", "01 Apr 2023", 30, 3));
        activities.Add(new CyclingAct("Cycling", "01 Apr 2023", 30, 7));
        activities.Add(new SwimmingAct("Swimming", "01 Apr 2023", 30, 100));
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}