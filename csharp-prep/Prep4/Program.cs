using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int isFinished = 1;
        List<int> numList = new List<int>();
        while (isFinished != 0) {
            Console.Write("Enter in a number: ");
            isFinished = Convert.ToInt32(Console.ReadLine());
            if (isFinished != 0) {
                numList.Add(isFinished);
            }
        }
        numList.Sort();
        int sum = 0;
        int largest = 0;
        int smallest = 100000;
        foreach (int num in numList) {
            sum = sum + num;
            if (num > largest) {
                largest = num;
            }
            if (num < smallest) {
                smallest = num;
            }
        }
        Console.Write(sum);
        float average = sum / numList.Count();
        Console.WriteLine(average);
        Console.WriteLine(largest);
        Console.WriteLine(smallest);
        foreach (int num in numList) {
            Console.WriteLine(num);
        }
    }
}