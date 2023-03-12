using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        GoalHandler goalHandler = new GoalHandler();
        Score userScore = new Score();
        bool isActive = true;
        List<Func<bool>> functions = new List<Func<bool>>();
        functions.Add(() => CreateNewGoal(goals));
        functions.Add(() => ListGoals(goals));
        functions.Add(() => SaveGoals(goals, goalHandler, userScore));
        functions.Add(() => LoadGoals(goals, goalHandler, userScore));
        functions.Add(() => RecordEvent(goals, userScore));
        functions.Add(Quit);
        while(isActive) {
            MainMenuDisplay((userScore.GetScore()));
            isActive = functions[BoundInt(GetIntAnswer("Select a choice from the menu: "), 1 , 6) - 1]();
        }
    }
    static void MainMenuDisplay(int points)
    {
        Console.WriteLine($"You have {points} points");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }
    static int BoundInt(int num, int lowerBound, int upperBound)
    {
        if(num < lowerBound) {
            num = lowerBound;
        }
        if(num > upperBound) {
            num = upperBound;
        }
        return num;
    }
    static int StrToInt(string s)
    {
        int n = Convert.ToInt32(s);
        return n;
    }
    static string GetStringAnswer(string writeline)
    {
        Console.Write(writeline);
        string userInput = Console.ReadLine();
        return userInput;
    }
    static int GetIntAnswer(string writeline)
    {
        Console.Write(writeline);
        int userInput = Convert.ToInt32(Console.ReadLine());
        return userInput;
    }
    static string askFileName() {
        string userInput = GetStringAnswer("What is the file name for the goal file?: ");
        return userInput;
    }
    static bool CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        int goalType = GetIntAnswer("Which type of goal would you like to create? ");
        string goalName = GetStringAnswer("What is the name of your goal? ");
        string goalDesc = GetStringAnswer("What is a short description of it? ");
        int goalPoints = GetIntAnswer("What is the amount of points associated with this goal? ");
        if(goalType == 1) {
            goals.Add(new SimpleGoal(1, goalName, goalDesc, goalPoints));
        }
        if(goalType == 2) {
            goals.Add(new EternalGoal(2, goalName, goalDesc, goalPoints));
        }
        if(goalType == 3) {
            int bonusChecks = GetIntAnswer("How many times does this need to be accomplished for a bonus? ");
            int bonus = GetIntAnswer("What is the bonus for accomplishing it that many times? ");
            goals.Add(new ChecklistGoal(3, goalName, goalDesc, goalPoints, bonusChecks, bonus));
        }
        Console.WriteLine();
        return true;
    }
    static bool ListGoals(List<Goal> goals)
    {
        for(int i = 0; i < goals.Count; i++) {
            Console.WriteLine($"{i + 1}. [{CompletionMarker(goals[i])}] {goals[i].DisplayGoal()} ");
        }
        Console.WriteLine();
        return true;
    }
    static bool SaveGoals(List<Goal> goals, GoalHandler goalHandler, Score userScore)
    {
        string requestedFile = GetStringAnswer("What is the file name for the goal file?: ");
        List<string> goalStrings = new List<string>();
        foreach(Goal g in goals) {
            goalStrings.Add(g.RetrieveInfo());
        }
        goalHandler.SaveGoals(requestedFile, userScore, goalStrings);
        Console.WriteLine();
        return true;
    }
    static bool LoadGoals(List<Goal> goals, GoalHandler goalHandler, Score userScore)
    {
        Console.WriteLine("Warning! This will erase any current records. Type incorrect file name to cancel.");
        string requestedFile = GetStringAnswer("What is the file name for the goal file?: ");
        if(File.Exists(requestedFile)) {
            goals.Clear();
            List<string[]> requestedInfo = goalHandler.LoadGoalContents(requestedFile);
            userScore.SetScore(Convert.ToInt32(requestedInfo[0][0]));
            InitializeGoals(goals, requestedInfo);
        }
        else {
            Console.WriteLine("File does not exist");
        }
        Console.WriteLine();
        return true;
    }
    static bool RecordEvent( List<Goal> goals, Score userScore)
    {
        if(goals.Count == 0) {
            Console.WriteLine("No goals to display. Try creating a new goal");
            Console.WriteLine();
            return true;
        }
        for(int i = 0; i < goals.Count; i++) {
            Console.WriteLine($"  {i + 1}. {goals[i].GetName()} ");
        }
        int selector = BoundInt(GetIntAnswer("Which goal did you accomplish today?: ") - 1, 0, goals.Count);
        Goal goal = goals[selector];
        if(goal.IsComplete()) {
            Console.WriteLine("Goal already complete. ");
            Console.WriteLine();
            return true;
        }
        RecordGoal(userScore, goal);
        Console.WriteLine();
        return true;
    }
    static bool Quit()
    {
        return false;
    }
    static void RecordGoal(Score s, Goal g)
    {
        g.AddCheck(1);
        int points = g.GetPoints();
        if(g.GetGoalType() == 3) {
            if(g.IsComplete()) {
                points = points + g.GetBonus();
            }
        }
        EarnPonts(s, points);
    }
    static void InitializeGoals(List<Goal> goals, List<string[]> requestedInfo)
    {
        foreach(string[] s in requestedInfo) {
            if(s != requestedInfo[0]) {
                if(StrToInt(s[0]) == 1) {
                    goals.Add(new SimpleGoal(StrToInt(s[0]), s[1], s[2], StrToInt(s[3]), StrToInt(s[4])));
                }
                if(StrToInt(s[0]) == 2) {
                    goals.Add(new EternalGoal(StrToInt(s[0]), s[1], s[2], StrToInt(s[3]), StrToInt(s[4])));
                }
                if(StrToInt(s[0]) == 3) {
                    goals.Add(new ChecklistGoal(StrToInt(s[0]), s[1], s[2], StrToInt(s[3]), StrToInt(s[4]), StrToInt(s[5]), StrToInt(s[6])));
                }
            }
        }
    }
    static void EarnPonts(Score userScore, int points)
    {
        Console.WriteLine($"Congratulations! You have earned {points} points! ");
        userScore.AddScore(points);
    }
    static string CompletionMarker(Goal g)
    {
        string x= "";
        if(g.IsComplete()) {
            x = "X";
        }
        return x;
    }
}