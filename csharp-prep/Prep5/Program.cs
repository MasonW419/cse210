using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        num = SquareNumber(num);
        DisplayResults(name, num);
    }
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName() {
        string name;
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber() {
        int num;
        Console.Write("Please enter your favorite number: ");
        num = Convert.ToInt16(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num) {
        int answer = Convert.ToInt32(num * num);
        return answer;
    }
    static void DisplayResults(string name, int num) {
        Console.WriteLine($"{name}, the square of your number is: {num}");
    }
}