using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test = new Fraction();
        Fraction test2 = new Fraction(5);
        Fraction test3 = new Fraction(3, 4);
        Console.WriteLine(test.GetFractionString());
        Console.WriteLine(test.GetDecimalValue());
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());
        Console.WriteLine("Hello Learning03 World!");
    }
}