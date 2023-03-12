using System;

class GoalHandler
{
    public GoalHandler()
    {}
    public void SaveGoals(string file, Score userScore, List<string> goalInfo) {
        using (StreamWriter outputFile = new StreamWriter(file)) {
            outputFile.WriteLine(userScore.GetScore());
            foreach(string i in goalInfo) {
                outputFile.WriteLine(i);
            }
        }
    }
    public List<string[]> LoadGoalContents(string file) {
        List<string[]> contents = new List<string[]>();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach(string line in lines) {
            string[] parts = line.Split(',');
            contents.Add(parts);
        }
        return contents;
    }
}