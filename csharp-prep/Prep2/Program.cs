using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade_percent = Convert.ToInt32(Console.ReadLine());
        string grade_let = "";
        if (grade_percent >= 90)
        {
            grade_let = "A";
        }
        else if (grade_percent >= 80)
        {
            grade_let = "B";
        } 
        else if (grade_percent >= 70)
        {
            grade_let = "C";
        } 
        else if (grade_percent >= 60)
        {
            grade_let = "D";
        } 
        else
        {
            grade_let = "F";
        } 
        Console.WriteLine($"Your grade is {grade_let}");
    }
}